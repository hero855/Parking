using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using Parking.objects;
using System.Data;

namespace Parking
{
    internal static class SqlFunctions
    {
        internal static string ConnectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|\\data\\Parking.mdf;" +
            "Integrated Security=True;";

        internal static string dbFileName = "|DataDirectory|\\data\\Parking.mdf";

        internal static List<UnitOfMeasure> GetUnitsOfMeasureFromDB()
        {
            List<UnitOfMeasure> unitsOfMeasure = new List<UnitOfMeasure>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Единицы измерения]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    string unit;
                    while (reader.Read())
                    {
                        unit = reader[0].ToString();
                        UnitOfMeasure unitOfMeasure = new UnitOfMeasure(unit);
                        unitsOfMeasure.Add(unitOfMeasure);
                    }
                }
            }
            return unitsOfMeasure;
        }

        internal static bool checkAllTables()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                foreach (string tableName in new List<string>() {
                        "dbo.Абонименты",
                        "dbo.[Виды аренды]",
                        "dbo.[Единицы измерения]",
                        "dbo.[Клиенты]",
                        "dbo.[Парковочные места]",
                        "dbo.[Этажи]"})
                {
                    string query = "SELECT COUNT(1) WHERE EXISTS (SELECT * FROM [dbo].[Абонименты]);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("tableName", SqlDbType.NVarChar).Value = tableName;

                    bool isEmpty;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        isEmpty = !Convert.ToBoolean(int.Parse(reader[0].ToString()));
                    }
                    if (isEmpty)
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        internal static string GetTypeOfColumn(string table, string col)
        {
            string type = "int";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = 
                    "SELECT DATA_TYPE "
                    + "FROM INFORMATION_SCHEMA.COLUMNS "
                    + "WHERE "
                    + "TABLE_NAME = N'@tableName' AND "
                    + "COLUMN_NAME = N'@colName';";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("tableName", SqlDbType.NVarChar).Value = table;
                cmd.Parameters.Add("colName", SqlDbType.NVarChar).Value = col;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Messages.Debug(table + '\n' + col);
                        type = reader[0].ToString();
                    }
                }
            }
            return type;
        }

        internal static double GetAvgExtendsOfPass(string typeOfRent)
        {
            double avg = 0.0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Количество продлений] FROM [dbo].[Абонименты] WHERE [Вид аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    double sum = 0.0;
                    double num = 0.0;
                    while (reader.Read())
                    {
                        double n = double.Parse(reader[0].ToString());
                        sum += n + 1;
                        num++;
                    }
                    if (num > 0)
                    {
                        avg = sum / num;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            return avg + 1;
        }

        internal static void RunQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Messages.sendErrorMessage("QUERY = " + query + "\n\nERROR = " + ex.Message);
                }
            }
        }

        internal static int GetLastCustomerIDInDB()
        {
            int lastId;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT COUNT(1) WHERE EXISTS (SELECT * FROM [dbo].[Клиенты]);";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                bool isEmpty;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    isEmpty = !Convert.ToBoolean(int.Parse(reader[0].ToString()));
                }
                if (!isEmpty)
                {
                    query = "SELECT MAX([Номер клиента]) FROM [dbo].[Клиенты]";
                    cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        lastId = int.Parse(reader[0].ToString());
                    }
                }
                else
                {
                    conn.Close();
                    return 1;
                }
            }
            return lastId;
        }

        internal static bool CheckDiactivationDateIsNull(int passId)
        {
            bool isNull;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Дата диактивации] FROM [Абонименты] WHERE [Номер абонимента] = @passId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("passId", SqlDbType.Int).Value = passId;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    try
                    {
                        isNull = reader[0] == DBNull.Value;
                    }
                    catch
                    {
                        isNull = true;
                    }
                }
            }
            return isNull;
        }

        internal static int GetPriceOfTypeOfRent(string typeOfRent)
        {
            int price;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Стоимость] FROM [dbo].[Виды аренды] WHERE [Название аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    price = int.Parse(reader[0].ToString());
                }
            }
            return price;
        }

        internal static int GetNumOfPassesByTypeOfRent(string typeOfRent)
        {
            int numOfPasses = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Абонименты] WHERE [Вид аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        numOfPasses++;
                    }
                }
            }
            return numOfPasses;
        }

        internal static List<int> GetSlotIdsByTypeOfRent(string typeOfRent)
        {
            List<int> floorIds = new List<int>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Номер этажа] FROM [dbo].[Этажи] WHERE [Вид аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    floorIds.Add(int.Parse(reader[0].ToString()));
                }
            }
            List<int> slotsIds = new List<int>();
            foreach (int floorId in floorIds)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT [Номер места] FROM [dbo].[Парковочные места] WHERE [Номер этажа] = @floorId;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("floorId", SqlDbType.Int).Value = floorId;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            slotsIds.Add(int.Parse(reader[0].ToString()));
                        }
                    }
                }
            }
            return slotsIds;
        }

        internal static List<int> GetAvalibleSlotsId(string typeOfRent)
        {
            List<int> floorIds = new List<int>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Номер этажа] FROM [dbo].[Этажи] WHERE [Вид аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    floorIds.Add(int.Parse(reader[0].ToString()));
                }
            }
            List<int> slotsIds = new List<int>();
            foreach (int floorId in floorIds)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT [Номер места] FROM [dbo].[Парковочные места] WHERE [Номер этажа] = @floorId AND [Занято] = 0;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("floorId", SqlDbType.Int).Value = floorId;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            slotsIds.Add(int.Parse(reader[0].ToString()));
                        }
                    }
                }
            }
            return slotsIds;
        }

        internal static void TakeSlot(int? slotId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE [dbo].[Парковочные места] SET [Занято] = 1 WHERE [Номер места] = @slotId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("slotId", SqlDbType.Int).Value = slotId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        internal static SqlDataReader RunQueryReader(string query)
        {
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            return reader;
        }
        //
        // Data getters
        //
        internal static List<Floor> GetFloorsFromDB()
        {
            List<Floor> floors = new List<Floor>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Этажи]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int floorId, numOfSlots;
                    string passPlan;
                    while (reader.Read())
                    {
                        floorId = int.Parse(reader[0].ToString());
                        numOfSlots = int.Parse(reader[1].ToString());
                        passPlan = reader[2].ToString();
                        Floor floor = new Floor(floorId, numOfSlots, passPlan);
                        floors.Add(floor);
                    }
                }
            }
            return floors;
        }

        internal static string GetUnitsOfMeasureOfTypeOfRent(string typeOfRent)
        {
            string unitOfMeasure;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query =
                    "SELECT [Единицы измерения]" +
                    "FROM [dbo].[Виды аренды]" +
                    "WHERE [Название аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    unitOfMeasure = reader[0].ToString();
                }
            }
            return unitOfMeasure;
        }

        internal static int GetLastFloorIDInDB()
        {
            int lastId;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT MAX([Номер этажа]) FROM [dbo].[Этажи]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    lastId = int.Parse(reader[0].ToString());
                }
            }
            return lastId;
        }

        internal static int GetLastSlotIDInDB()
        {
            int lastId;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT MAX([Номер места]) FROM dbo.[Парковочные места]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    lastId = int.Parse(reader[0].ToString());
                }
            }
            return lastId;
        }

        internal static int GetLastPassIDInDB()
        {
            int passId;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT MAX([Номер абонимента]) FROM [dbo].[Абонименты];";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    try
                    {
                        passId = int.Parse(reader[0].ToString());
                    }
                    catch (FormatException ex)
                    {
                        passId = 0;
                    }
                }
            }
            return passId;
        }

        internal static List<Slot> GetSlotsFromDB()
        {
            List<Slot> slots = new List<Slot>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Парковочные места]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int slotId, floorId;
                    bool isBusy;
                    while (reader.Read())
                    {
                        slotId = int.Parse(reader[0].ToString());
                        floorId = int.Parse(reader[1].ToString());
                        isBusy = bool.Parse(reader[2].ToString());
                        Slot slot = new Slot(slotId, floorId, isBusy);
                        slots.Add(slot);
                    }
                }
            }
            return slots;
        }

        internal static string GetTypeOfRentBySlotId(int slotId)
        {
            string typeOfRent;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT [Номер этажа] FROM [dbo].[Парковочные места] WHERE [Номер места] = @slotId                                                                                       ;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("slotId", SqlDbType.Int).Value = slotId;
                conn.Open();
                int floorId;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    floorId = int.Parse(reader[0].ToString());
                }
                conn.Close();

                query = "SELECT [Вид аренды] FROM [dbo].[Этажи] WHERE [Номер этажа] = @floorId;";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("floorId", SqlDbType.Int).Value = floorId;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    typeOfRent = reader[0].ToString();
                }
            }
            return typeOfRent;
        }

        internal static List<Customer> GetCustomersFromDB()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Клиенты]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int customerId;
                    string autoType, phoneNumber;
                    bool isRegularCustomer;
                    while (reader.Read())
                    {
                        customerId = int.Parse(reader[0].ToString());
                        autoType = reader[1].ToString();
                        isRegularCustomer = bool.Parse(reader[2].ToString());
                        phoneNumber = reader[3].ToString();
                        Customer customer = new Customer(customerId, autoType, isRegularCustomer, phoneNumber);
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }

        internal static List<Pass> GetPassesFromDB()
        {
            List<Pass> passes = new List<Pass>();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Абонименты]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int passId, customerId, numOfExtends;
                    int? slotId;
                    DateTime activationDate;
                    string planName;
                    while (reader.Read())
                    {
                        passId = int.Parse(reader[0].ToString());
                        customerId = int.Parse(reader[1].ToString());
                        if (reader[2] == DBNull.Value)
                        {
                            slotId = null;
                        }
                        else
                        {
                            slotId = int.Parse(reader[2].ToString());
                        }
                        planName = reader[3].ToString();
                        activationDate = reader.GetDateTime(4);
                        numOfExtends = int.Parse(reader[6].ToString());
                        Pass pass = new Pass(passId, customerId, slotId, planName, activationDate, numOfExtends);
                        passes.Add(pass);
                    }
                }
            }
            return passes;
        }

        internal static List<TypeOfRent> GetTypesOfRentFromDB()
        {
            List<TypeOfRent> typesOfRent = new List<TypeOfRent>();
            using (var conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM dbo.[Виды аренды] ORDER BY [Стоимость] ASC;";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader[0].ToString();
                        int price = int.Parse(reader[1].ToString());
                        string unitOfMeasure = reader[2].ToString();
                        typesOfRent.Add(new TypeOfRent(name, price, unitOfMeasure));
                    }
                }
            }
            return typesOfRent;
        }
        //
        // Create/Drop Database
        //
        internal static bool CheckDBIsExitsts()
        {
            bool dbIsEmpty;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query =
                    "IF DB_ID('|DataDirectory|\\bin\\debug\\data\\Parking.mdf') IS NOT NULL"
                    + "SELECT 1"
                    + "ELSE"
                    + "SELECT 0";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    dbIsEmpty = bool.Parse(reader.ToString());
                }
            }
            return dbIsEmpty;
        }

        internal static void DropLinks()
        {
            RunQuery(
                "ALTER TABLE [dbo].[Абонименты] DROP CONSTRAINT [FK_ВидАрендыАбонимент];"
                + "ALTER TABLE [dbo].[Абонименты] DROP CONSTRAINT [FK_КлиентАбонимент];"
                + "ALTER TABLE [dbo].[Абонименты] DROP CONSTRAINT [FK_МестоАбонимент];"
                + "ALTER TABLE [dbo].[Этажи] DROP CONSTRAINT [FK_ВидАрендыЭтаж]"
                + "ALTER TABLE [dbo].[Парковочные места] DROP CONSTRAINT [FK_ЭтажМесто];"
            );
        }

        internal static void DropTables()
        {
            RunQuery(
                "DROP TABLE [dbo].[Виды аренды];"
                + "DROP TABLE [dbo].[Единицы измерения];"
                + "DROP TABLE [dbo].[Абонименты];"
                + "DROP TABLE [dbo].[Клиенты];"
                + "DROP TABLE [dbo].[Парковочные места];"
                + "DROP TABLE [dbo].[Этажи];"
            );
        }

        internal static void GenerateTestData()
        {
            FillTables();
        }

        internal static void DeleteDataFromDB()
        {
            DropLinks();
            TruncateTables();
            CreateLinks();
        }

        private static void TruncateTables()
        {
            RunQuery(
                "TRUNCATE TABLE [dbo].[Этажи];"
                + "TRUNCATE TABLE [dbo].[Парковочные места];"
                + "TRUNCATE TABLE [dbo].[Клиенты];"
                + "TRUNCATE TABLE [dbo].[Абонименты];"
                + "TRUNCATE TABLE [dbo].[Виды аренды];"
                + "TRUNCATE TABLE [dbo].[Единицы измерения];"
            );
        }

        internal static void CreateTables()
        {
            RunQuery(
                "CREATE TABLE [dbo].[Единицы измерения] ("
                + "   [Единица измерения] [varchar](80) PRIMARY KEY NOT NULL"
                + ");"
                + "CREATE TABLE [dbo].[Виды аренды] ("
                + "   [Название аренды] [varchar](80) PRIMARY KEY NOT NULL,"
                + "   [Стоимость] [int] NOT NULL,"
                + "   [Единицы измерения] [varchar](80) NOT NULL"
                + ");"
                + "CREATE TABLE [dbo].[Парковочные места] ("
                + "   [Номер места] [int] PRIMARY KEY NOT NULL,"
                + "   [Номер этажа] [int] NOT NULL,"
                + "   [Занято] [bit]"
                + ");"
                + "CREATE TABLE [dbo].[Этажи] ("
                + "   [Номер этажа] [int] PRIMARY KEY NOT NULL,"
                + "   [Количество мест] [int] NOT NULL,"
                + "   [Вид аренды] [varchar](80) NOT NULL"
                + ");"
                + "CREATE TABLE [dbo].[Абонименты] ("
                + "   [Номер абонимента] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,"
                + "   [Номер клиента] [int] NOT NULL,"
                + "   [Номер места] [int] NULL,"
                + "   [Вид аренды] [varchar](80) NOT NULL,"
                + "   [Дата активации] [datetime] NOT NULL,"
                + "   [Дата диактивации] [datetime] NULL,"
                + "   [Количество продлений] INT NOT NULL"
                + ");"
                + "CREATE TABLE [dbo].[Клиенты] ("
                + "   [Номер клиента] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,"
                + "   [Тип машины] [varchar](80) NOT NULL,"
                + "   [Это постоянный клиент] [bit] NOT NULL,"
                + "   [Контактный номер] [varchar](20) NULL"
                + ");"
            );
        }

        internal static void FillTables()
        {
            new UnitOfMeasure("rph").INSERT();
            new UnitOfMeasure("rpm").INSERT();


            new TypeOfRent("Single", 100, "rph").INSERT();
            new TypeOfRent("Subscribe \"Basic\"", 2000, "rpm").INSERT();
            new TypeOfRent("Subscribe \"Advanced\"", 3000, "rpm").INSERT();


            Floor floor1 = new Floor(1, 70, "Subscribe \"Advanced\"");
            Floor floor2 = new Floor(2, 70, "Subscribe \"Basic\"");
            Floor floor3 = new Floor(3, 70, "Single");

            floor1.INSERT();
            floor2.INSERT();
            floor3.INSERT();

            floor1.CreateSlots();
            floor2.CreateSlots();
            floor3.CreateSlots();


            RunQuery("SET IDENTITY_INSERT[dbo].[Клиенты] ON");
            Random rnd = new Random();
            DateTime date = DateTime.Now;
            date = date.AddMonths(-3);
            Customer cust;
            Pass pass;
            List<Customer> customers = new List<Customer>();
            double P = 2.3;
            int k;
            while (date < DateTime.Now)
            {
                date = date.AddDays(1);
                TimeSpan ts = new TimeSpan(8, 0, 0);
                date = date.Date + ts;
                while (date.Hour < 23 && date.Hour >= 8)
                {
                    date = date.AddMinutes(rnd.Next(180));
                    k = (int)(100 * P / (customers.Count + P));
                    if (k > rnd.Next(100))
                    {
                        cust = new Customer("Passenger", false, Functions.generatePhoneNumber());
                        cust.INSERT();
                        string typeOfRent;
                        k = rnd.Next(6);
                        if (k < 3)
                        {
                            typeOfRent = "Single";
                        }
                        else if (k < 5)
                        {
                            typeOfRent = "Subscribe \"Basic\"";
                        }
                        else
                        {
                            typeOfRent = "Subscribe \"Advanced\"";
                        }
                        List<int> avaliableSlotsId = GetAvalibleSlotsId(typeOfRent);
                        if (avaliableSlotsId.Count > 0)
                        {
                            int slotId = avaliableSlotsId[rnd.Next(avaliableSlotsId.Count)];
                            cust.CreatePass(slotId, date);
                            pass = cust.getPass();
                            if (pass.typeOfRent == "Single")
                            {
                                pass.extendRent(rnd.Next(7));
                            }
                            date.AddMinutes(90);
                            customers.Add(cust);
                        }
                        else
                        {
                            cust.DELETE();
                        }
                    }
                    else
                    {

                    }
                }
            }
            RunQuery("SET IDENTITY_INSERT[dbo].[Клиенты] OFF");
        }

        private static bool CheckSlotIsBusy(int? slotId)
        {
            return true;
        }

        internal static void CreateLinks() => RunQuery(
            "ALTER TABLE [dbo].[Этажи] WITH CHECK ADD CONSTRAINT [FK_ВидАрендыЭтаж] FOREIGN KEY ([Вид аренды])"
            + "REFERENCES [dbo].[Виды аренды]([Название аренды]);"
            + "ALTER TABLE [dbo].[Этажи] CHECK CONSTRAINT [FK_ВидАрендыЭтаж];"
            + "ALTER TABLE [dbo].[Абонименты] WITH CHECK ADD CONSTRAINT[FK_КлиентАбонимент] FOREIGN KEY([Номер клиента])"
            + "REFERENCES [dbo].[Клиенты]([Номер клиента]);"
            + "ALTER TABLE [dbo].[Абонименты] CHECK CONSTRAINT [FK_КлиентАбонимент];"
            + "ALTER TABLE [dbo].[Абонименты] WITH CHECK ADD CONSTRAINT[FK_ВидАрендыАбонимент] FOREIGN KEY([Вид аренды])"
            + "REFERENCES [dbo].[Виды аренды]([Название аренды]);"
            + "ALTER TABLE [dbo].[Абонименты] CHECK CONSTRAINT [FK_ВидАрендыАбонимент];"
            + "ALTER TABLE [dbo].[Абонименты] WITH CHECK ADD CONSTRAINT[FK_МестоАбонимент] FOREIGN KEY([Номер места])"
            + "REFERENCES [dbo].[Парковочные места]([Номер места]);"
            + "ALTER TABLE [dbo].[Абонименты] CHECK CONSTRAINT [FK_МестоАбонимент];"
            + "ALTER TABLE [dbo].[Парковочные места] WITH CHECK ADD CONSTRAINT[FK_ЭтажМесто] FOREIGN KEY([Номер этажа])"
            + "REFERENCES [dbo].[Этажи]([Номер этажа]);"
            + "ALTER TABLE [dbo].[Парковочные места] CHECK CONSTRAINT[FK_ЭтажМесто];"
        );
        //
        // Other
        //
        internal static void ResetIdentity(string tableName, string idColName)
        {
            // TODO: complete function
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                int max = 0;
                string query1 = "SELECT MAX([Номер места]) FROM [Парковочные места];";
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("tableName", tableName);
                cmd.Parameters.AddWithValue("idColName", idColName);
                //string query = cmd.CommandText;
                //foreach (SqlParameter p in cmd.Parameters)
                //{
                //    query = query.Replace(p.ParameterName, p.Value.ToString());
                //}
                //Console.WriteLine(query);
                //cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    max = int.Parse(reader[0].ToString());
                }

                Console.WriteLine(max);

                string query2 = "DBCC CHECKIDENT('[@tableName]', RESEED, @max);";
                cmd = new SqlCommand(query2, conn);
                cmd.Parameters.AddWithValue("tableName", tableName);
                cmd.Parameters.AddWithValue("max", max);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
