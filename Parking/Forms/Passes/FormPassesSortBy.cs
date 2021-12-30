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
    public partial class FormPassesSortBy : Form
    {
        FormPasses parent;

        public FormPassesSortBy(FormPasses parent)
        {
            InitializeComponent();
            UpdateComboboxs();
            this.parent = parent;
        }

        private void UpdateComboboxs()
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Абонименты';";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxColumnName.Items.Add(reader[0]);
                    }
                }
            }
            comboBoxOrder.Items.Add("По убыванию");
            comboBoxOrder.Items.Add("По возрастанию");
        }

        private void iconButtonSortby_Click(object sender, EventArgs e)
        {
            parent.showSorted(comboBoxColumnName.Text, comboBoxOrder.Text);
            Close();
        }
    }
}
