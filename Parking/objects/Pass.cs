using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using Parking.Forms.Slots;

namespace Parking.objects
{
    public class Pass
    {
        public int id;
        public int customerId;
        public int? slotId;
        public string typeOfRent;
        public  DateTime activationDate;
        public DateTime? diactivationDate
        {
            get
            {
                string unitOfMeasure = Functions.getUnitOfMeasure(typeOfRent);
                if (unitOfMeasure == "rpm")
                {
                    DateTime _diactivationDate = activationDate.AddMonths(numOfExtends + 1);
                    if (SqlFunctions.CheckDiactivationDateIsNull(this.id))
                    {
                        using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
                        {
                            string query =
                                "UPDATE [dbo].[Абонименты]" +
                                "SET [Дата диактивации] = @diactivationDate " +
                                "WHERE [Номер абонимента] = @passId;";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.Add("diactivationDate", SqlDbType.DateTime).Value = _diactivationDate;
                            cmd.Parameters.Add("passId", SqlDbType.Int).Value = this.id;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return _diactivationDate;
                }
                else
                {
                    return null;
                }
            }
        }
        public int numOfExtends;

        public Pass(int id, int customerId, int? slotId, string typeOfRent, DateTime activationDate, int numOfExtends)
        {
            this.id = id;
            this.customerId = customerId;
            this.slotId = slotId;
            this.typeOfRent = typeOfRent;
            this.activationDate = activationDate;
            //if (typeOfRent == "Single")
            //{
            //    Messages.Debug(slotId + "\n" + typeOfRent + "\n" + activationDate.ToString("HH:mm dd MMM yyyy"));
            //}
            //else
            //{
            //    Messages.Debug(slotId + "\n" + typeOfRent + "\n" + activationDate.ToString("dd MMM yyyy"));
            //}
            this.numOfExtends = numOfExtends;
        }

        public void INSERT()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "INSERT INTO [dbo].[Абонименты]" +
                    "([Номер клиента], [Номер места], [Вид аренды], [Дата активации], [Дата диактивации], [Количество продлений])" +
                    "VALUES (@customerId, @slotId, @typeOfRent, @activationDate, @diactivationDate, @numOfExtends);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = customerId;
                if (slotId != null)
                {
                    cmd.Parameters.Add("slotId", SqlDbType.Int).Value = slotId;
                }
                else
                { 
                    cmd.Parameters.Add("slotId", SqlDbType.Int).Value = SqlInt32.Null;
                }
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar, 80).Value = typeOfRent;
                cmd.Parameters.Add("activationDate", SqlDbType.DateTime).Value = activationDate;
                cmd.Parameters.Add("diactivationDate", SqlDbType.DateTime).Value = (object)diactivationDate ?? DBNull.Value;
                cmd.Parameters.Add("numOfExtends", SqlDbType.Int).Value = numOfExtends;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            SqlFunctions.TakeSlot(slotId);
        }

        public void UPDATE()
        {
            if (typeOfRent != SqlFunctions.GetTypeOfRentBySlotId((int)slotId))
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "FormSelectSlot")
                    {
                        return;
                    }
                }
            }
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "UPDATE [dbo].[Абонименты]" +
                    "SET [Номер клиента] = @customerId," +
                    "    [Номер места] = @slotId," +
                    "    [Вид аренды] = @typeOfRent," +
                    "    [Дата активации] = @activationDate," +
                    "    [Дата диактивации] = @diactivationDate," +
                    "    [Количество продлений] = @numOfExtends " +
                    "WHERE [Номер абонимента] = @passId;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("passId", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = customerId;
                cmd.Parameters.Add("slotId", SqlDbType.Int).Value = slotId;
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar, 80).Value = typeOfRent;
                cmd.Parameters.Add("activationDate", SqlDbType.DateTime).Value = activationDate;
                cmd.Parameters.Add("diactivationDate", SqlDbType.DateTime).Value = (object)diactivationDate ?? DBNull.Value;
                cmd.Parameters.Add("numOfExtends", SqlDbType.Int).Value = numOfExtends;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        internal string getUnitsOfMeasure()
        {
            string unitsOfMeasure;
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT [Единицы измерения] FROM [Виды аренды] WHERE [Название аренды] = @typeOfRent;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("typeOfRent", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    unitsOfMeasure = reader[0].ToString();
                }
            }
            return unitsOfMeasure;
        }

        public void DELETE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "DELETE FROM [dbo].[Абонименты]" +
                    "WHERE [Номер абонимента] = @passId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("passId", SqlDbType.Int).Value = id;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            // TODO: resetIdentity("Абонименты", "Номер абонимента");
        }

        public void extendRent(int num)
        {
            numOfExtends += num;
            UPDATE();
        }
    }
}
