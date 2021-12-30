using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Parking.Forms.Passes
{
    public partial class FormPassesFilterBy : Form
    {
        FormPasses parent;
        public FormPassesFilterBy(FormPasses parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private List<string> GetColumnNames()
        {
            List<string> columns = new List<string>();
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Абонименты';";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader[0].ToString());
                    }
                }
            }
            return columns;
        }

        private void iconButtonFilterBy_Click(object sender, EventArgs e)
        {
            parent.ShowFiltered(GetQuery());
        }

        private List<string> CollectData()
        {
            List<string> data = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index < dataGridView1.Rows.Count - 1)
                {
                    string cond = "[" + row.Cells[0].Value.ToString() + "] " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                    data.Add(cond);
                }
            }
            return data;
        }

        public string GetQuery()
        {
            string query = "SELECT * FROM [dbo].[Абонименты] WHERE ";
            List<string> data = CollectData();
            foreach (string cond in data)
            {
                query += cond;
                if (data.IndexOf(cond) < data.Count - 1)
                {
                    query += " AND ";
                }
                else
                {
                    query += ";";
                }
            }
            Messages.Debug(query);
            return query;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            DataGridViewComboBoxCell cell1 = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell cell2 = new DataGridViewComboBoxCell();

            foreach (string colName in GetColumnNames())
            {
                cell1.Items.Add(colName);
            }
            cell2.Items.Add("=");
            cell2.Items.Add(">");
            cell2.Items.Add("<");
            cell2.Items.Add(">=");
            cell2.Items.Add("<=");

            cell1.Value = selectedRow.Cells[0].Value;
            cell2.Value = selectedRow.Cells[1].Value;

            selectedRow.Cells[0] = cell1;
            selectedRow.Cells[1] = cell2;
        }
    }
}
