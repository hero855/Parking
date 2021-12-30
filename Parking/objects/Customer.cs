using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;

namespace Parking.objects
{
    public class Customer
    {
        public int id;
        public string autoType;
        public bool isRegularCustomer;
        public string phoneNumber;

        public Customer(int id, string autoType, bool isRegularCustomer, string phoneNumber)
        {
            this.id = id;
            this.autoType = autoType;
            this.isRegularCustomer = isRegularCustomer;
            this.phoneNumber = phoneNumber;
        }

        public Customer(string autoType, bool isRegularCustomer, string phoneNumber)
        {
            this.id = SqlFunctions.GetLastCustomerIDInDB();
            this.autoType = autoType;
            this.isRegularCustomer = isRegularCustomer;
            this.phoneNumber = phoneNumber;
        }

        public void INSERT()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "INSERT INTO [dbo].[Клиенты]" +
                    "([Тип машины], [Это постоянный клиент], [Контактный номер])" +
                    "VALUES (@autoType, @isRegularCustomer, @phoneNumber);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("autoType", SqlDbType.NVarChar, 80).Value = autoType;
                cmd.Parameters.Add("isRegularCustomer", SqlDbType.Bit).Value = isRegularCustomer;
                cmd.Parameters.Add("phoneNumber", SqlDbType.NVarChar, 20).Value = phoneNumber;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UPDATE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "UPDATE [dbo].[Клиенты]" +
                    "SET [Тип машины] = @autoType," +
                    "    [Это постоянный клиент] = @isRegularCustomer," +
                    "    [Контактный номер] = @phoneNumber" +
                    "WHERE [Номер клиента] = @customerId;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("autoType", SqlDbType.NVarChar, 80).Value = autoType;
                cmd.Parameters.Add("isRegularCustomer", SqlDbType.Bit).Value = isRegularCustomer;
                cmd.Parameters.Add("phoneNumber", SqlDbType.NVarChar, 20).Value = phoneNumber;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DELETE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "DELETE FROM [dbo].[Клиенты]" +
                    "WHERE [Номер клиента] = @customerId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = id;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            // TODO: resetIdentity("Клиенты", "Номер клиента");
        }

        public Pass getPass()
        {
            Pass pass;
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "SELECT * " +
                    "FROM [dbo].[Абонименты]" +
                    "WHERE [Номер клиента] = @customerId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = id;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    int id = int.Parse(reader[0].ToString());
                    int customerId = int.Parse(reader[1].ToString());
                    int slotId = int.Parse(reader[2].ToString());
                    string typeOfRent = reader[3].ToString();
                    DateTime activationDate = reader.GetDateTime(4);
                    int numOfExtends = int.Parse(reader[6].ToString());
                    pass = new Pass(id, customerId, slotId, typeOfRent, activationDate, numOfExtends);
                }
            }
            return pass;
        }

        internal void CreatePass(int slotId, DateTime activationDate)
        {
            string typeOfRent = SqlFunctions.GetTypeOfRentBySlotId(slotId);
            Pass pass = new Pass(id, this.id, slotId, typeOfRent, activationDate, 0);
            pass.INSERT();
        }
    }
}
