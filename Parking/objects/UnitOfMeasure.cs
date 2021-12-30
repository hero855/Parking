using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Parking.objects
{
    class UnitOfMeasure
    {
        public string unitOfMeasure;

        public UnitOfMeasure(string unitOfMeasure)
        {
            this.unitOfMeasure = unitOfMeasure;
        }

        public void INSERT()
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Единицы измерения] VALUES (@unitOfMeasure);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("unitOfMeasure", System.Data.SqlDbType.VarChar, 50).Value = unitOfMeasure;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
