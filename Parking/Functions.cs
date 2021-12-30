using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

using Parking.objects;

namespace Parking
{
    public static class Functions
    {
        internal static Color makeDarker(Color col, int k)
        {
            return Color.FromArgb(col.R - k, col.G - k, col.B - k);
        }

        internal static Color makeLighter(Color col, int k)
        {
            return Color.FromArgb(col.R + k, col.G + k, col.B + k);
        }

        internal static string getUnitOfMeasure(string typeOfRent)
        {
            string unitOfMeasure;
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query =
                    "SELECT [Единицы измерения] " +
                    "FROM [Виды аренды] " +
                    "WHERE [Название аренды] = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = typeOfRent;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    unitOfMeasure = reader[0].ToString();
                }
            }
            return unitOfMeasure;
        }

        internal static Color makeYellowed(Color col, int k)
        {
            return Color.FromArgb(col.R, col.G, col.B - k);
        }

        internal static Color makeReder(Color col, int k)
        {
            return Color.FromArgb(col.R, col.G - k / 2, col.B - k / 2);
        }

        internal static Color makeGreener(Color col, int k)
        {
            return Color.FromArgb(col.R - k / 2, col.G, col.B - k / 2);
        }

        internal static Color makeBluer(Color col, int k)
        {
            return Color.FromArgb(col.R - k / 2, col.G - k / 2, col.B);
        }

        internal static void DataGridViewAutoSizing(DataGridView TableGridView)
        {
            TableGridView.Width = 0;
            TableGridView.Height = 0;
            TableGridView.AutoSize = true;
            TableGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TableGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TableGridView.BackgroundColor = SystemColors.ControlLightLight;
            TableGridView.BorderStyle = BorderStyle.None;
        }

        internal static Color getCellColor(DataGridViewCellFormattingEventArgs e, DataGridView dataGridView)
        {
            Color defaultColor = Color.White;

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            int rowID = row.Index;
            bool idIsOdd = rowID % 2 != 0;
            Color col = defaultColor;

            if (idIsOdd)
            {
                col = makeDarker(col, 19);
            }

            if (e.Value is null)
            {
                e.Value = "NULL";
                col = makeYellowed(col, 25);
            }
            return col;
        }

        internal static string generatePhoneNumber()
        {
            Random rnd = new Random();
            string phone = "+7 (978) ";
            phone += rnd.Next(10);
            phone += rnd.Next(10);
            phone += rnd.Next(10);
            phone += "-";
            phone += rnd.Next(10);
            phone += rnd.Next(10);
            phone += "-";
            phone += rnd.Next(10);
            phone += rnd.Next(10);
            return phone;
        }
    }
}
