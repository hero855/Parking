using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Parking.objects
{
    class TypeOfRent
    {
        public string name;
        public int price;
        public string unitOfMeasure;

        public TypeOfRent(string name, int price, string unitOfMeasure)
        {
            this.name = name;
            this.price = price;
            this.unitOfMeasure = unitOfMeasure;
        }

        public void INSERT()
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "INSERT INTO [dbo].[Виды аренды]" +
                    "VALUES (@name, @price, @unitOfMeasure);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("price", SqlDbType.Int).Value = price;
                cmd.Parameters.Add("unitOfMeasure", SqlDbType.NVarChar, 80).Value = unitOfMeasure;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int getRentDurationInDays(TypeOfRent typeOfRent)
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "SELECT [Единици измерения ]" +
                    "FROM [dbo].[Виды аренды]" +
                    "WHERE [Название вида] = @typeOfRentName;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@typeOfRentName", SqlDbType.VarChar, 80).Value = name;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    int days = int.Parse(reader[0].ToString());
                    return days;
                }
            }
        }
    }
}
