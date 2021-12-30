using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Parking.objects
{
    public class Floor
    {
        public int id;
        public int numOfSlots;
        public string typeOfRent;

        public Floor(int id, int numOfSlots, string typeOfRent)
        {
            this.id = id;
            this.numOfSlots = numOfSlots;
            this.typeOfRent = typeOfRent;
        }

        public void INSERT()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Этажи]([Номер этажа], [Количество мест], [Вид аренды]) VALUES (@id, @numOfSlots, @typeOfRent);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@numOfSlots", SqlDbType.Int).Value = numOfSlots;
                cmd.Parameters.Add("@typeOfRent", SqlDbType.NVarChar, 80).Value = typeOfRent;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UPDATE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "UPDATE [dbo].[Этажи] SET [Количество мест] = @numOfSlots, [Вид аренды] = @typeOfRent WHERE [Номер этажа] = @id;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@numOfSlots", SqlDbType.Int).Value = numOfSlots;
                cmd.Parameters.Add("@typeOfRent", SqlDbType.NVarChar, 80).Value = typeOfRent;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DELETE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "DELETE FROM [dbo].[Этажи] WHERE [Номер этажа] = @id;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            // TODO: resetIdentity("Этажи", "Номер этажа");
        }

        public List<Slot> getSlots()
        {
            List<Slot> slots = new List<Slot>();
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT [Номер места], [Номер этажа], [Занято] FROM dbo.[Парковочные места] WHERE [Номер этажа] = @floorID;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("floorId", SqlDbType.Int).Value = id;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader[0].ToString());
                        int floorId = int.Parse(reader[1].ToString());
                        bool isBusy = bool.Parse(reader[3].ToString());
                        Slot slot = new Slot(id, floorId, isBusy);
                        slots.Add(slot);
                    }
                }
            }
            return slots;
        }

        public List<Slot> generateSlots()
        {
            // TODO: проверять совпадение индексов мест, количества мест и этажей
            List<Slot> slots = new List<Slot>();
            int lastId = SqlFunctions.GetLastSlotIDInDB();
            for (int i = 0; i < numOfSlots; i++)
            {
                int id = lastId + i + 1;
                int floorId = id;
                Slot slot = new Slot(id, floorId, false);
                slots.Add(slot);
            }
            return slots;
        }

        internal void CreateSlots()
        {
            for (int i = 0; i < numOfSlots; i++)
            {
                int id = (this.id - 1) * numOfSlots + i + 1;
                new Slot(id, this.id, false).INSERT();
            }
        }
    }
}
