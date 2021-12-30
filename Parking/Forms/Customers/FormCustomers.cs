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

using Parking.objects;

namespace Parking.Forms.Customers
{
    public partial class FormCustomers : Form
    {
        Customer customer;

        public FormCustomers()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private bool CollectData()
        {
            try
            {
                int customerId = SqlFunctions.GetLastCustomerIDInDB();
                string autoType = textBoxAutoType.Text;
                bool isRegular = checkBoxRegularCustomer.Checked;
                string phoneNumber = textBoxPhoneNumber.Text;
                if (autoType == "")
                {
                    throw new Exception();
                }
                customer = new Customer(customerId, autoType, isRegular, phoneNumber);
                return true;
            }
            catch
            {
                Messages.sendErrorMessage("Вы некорректно ввели данные");
                return false;
            }
        }

        private void UpdateTable()
        {
            dataGridViewCustomers.Rows.Clear();
            List<Customer> customers = SqlFunctions.GetCustomersFromDB();
            foreach (Customer cust in customers)
            {
                dataGridViewCustomers.Rows.Add(cust.id, cust.autoType, cust.isRegularCustomer, cust.phoneNumber);
            }
        }

        private void iconButtonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCustomers.Rows[e.RowIndex];
                textBoxCustomerID.Text = row.Cells[0].Value.ToString();
                textBoxAutoType.Text = row.Cells[1].Value.ToString();
                checkBoxRegularCustomer.Checked = Convert.ToBoolean(row.Cells[2].Value);
                textBoxPhoneNumber.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridViewCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Functions.getCellColor(e, dataGridViewCustomers);
        }

        private void iconButtonUPDATEAutoType_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "UPDATE [dbo].[Клиенты] SET [Тип машины] = @AutoType WHERE [Номер клиента] = @customerId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = textBoxCustomerID.Text;
                cmd.Parameters.Add("AutoType", SqlDbType.NVarChar).Value = textBoxAutoType.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            UpdateTable();
        }

        private void iconButtonUPDATEPhoneNumber_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "UPDATE [dbo].[Клиенты] SET [Контактный номер] = @phoneNumber WHERE [Номер клиента] = @customerId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("customerId", SqlDbType.Int).Value = textBoxCustomerID.Text;
                cmd.Parameters.Add("phoneNumber", SqlDbType.NVarChar).Value = textBoxPhoneNumber.Text;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            UpdateTable();
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void iconButtonCreateCustomer_Click(object sender, EventArgs e)
        {
            new FormNewCustomer().Show();
        }
    }
}
