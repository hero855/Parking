using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Parking.objects
{
    public class Slot
    {
        public int id;
        public int floorId;
        public bool isBusy;

        public Slot(int id, int floorId, bool isBusy)
        {
            this.id = id;
            this.floorId = floorId;
            this.isBusy = isBusy;
        }

        public void INSERT()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Парковочные места]([Номер места], [Номер этажа], [Занято]) VALUES (@id, @floor, @isBusy);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("floor", floorId);
                cmd.Parameters.AddWithValue("isBusy", isBusy);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UPDATE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "UPDATE [dbo].[Парковочные места] SET [Номер этажа] = @floor WHERE @id = [Номер места];";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("floor", floorId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DELETE()
        {
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "DELETE FROM [dbo].[Парковочные места] WHERE [Номер места] = @slotId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("slotId", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            // TODO: resetIdentity("Парковочные места", "Номер места");
        }

        internal static List<Slot> getSlotsFromDB()
        {
            List<Slot> slots = new List<Slot>();
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
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

        internal static int getLastSlotIDInDB()
        {
            int lastId;
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
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
    }
}
