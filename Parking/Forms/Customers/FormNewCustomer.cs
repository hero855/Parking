using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Parking.objects;

namespace Parking.Forms.Customers
{
    public partial class FormNewCustomer : Form
    {
        Customer customer;

        public FormNewCustomer()
        {
            InitializeComponent();
        }

        private void FormNewCustomer_Load(object sender, EventArgs e)
        {
            UpdateComboBoxes();
            textBoxCustomerID.Text = (SqlFunctions.GetLastCustomerIDInDB() + 1).ToString();
        }

        private void UpdateComboBoxes()
        {
            string val1 = comboBoxSlotId.Text;
            string val2 = comboBoxTypeOfRent.Text;
            bool both = comboBoxSlotId.Text != "" && comboBoxTypeOfRent.Text != "";
            bool noOne = comboBoxSlotId.Text == "" && comboBoxTypeOfRent.Text == "";
            if (noOne)
            {
                List<int> slotIds = new List<int>();
                foreach (TypeOfRent typeOfRent in SqlFunctions.GetTypesOfRentFromDB())
                {
                    comboBoxTypeOfRent.Items.Add(typeOfRent.name);
                    foreach (int slotId in SqlFunctions.GetAvalibleSlotsId(typeOfRent.name))
                    {
                        slotIds.Add(slotId);
                    }
                }
                slotIds.Sort();
                foreach (int slotId in slotIds)
                {
                    comboBoxSlotId.Items.Add(slotId.ToString());
                }
            }
            else if (!both)
            {
                if (comboBoxSlotId.Text != "")
                {
                    comboBoxTypeOfRent.Items.Clear();
                    comboBoxTypeOfRent.Text = val2;
                    int slotId = int.Parse(comboBoxSlotId.Text);
                    comboBoxTypeOfRent.Items.Add(SqlFunctions.GetTypeOfRentBySlotId(slotId));
                }
                else if (comboBoxTypeOfRent.Text != "")
                {
                    comboBoxSlotId.Items.Clear();
                    comboBoxSlotId.Text = val1;
                    string typeOfRent = comboBoxTypeOfRent.Text;
                    foreach (int slotId in SqlFunctions.GetSlotIdsByTypeOfRent(typeOfRent))
                    {
                        comboBoxSlotId.Items.Add(slotId);
                    }
                }
            }
            else if (both)
            {
                string selectedTypeOfRent = comboBoxTypeOfRent.Text;
                List<int> avaliableSlots = SqlFunctions.GetAvalibleSlotsId(selectedTypeOfRent);
                List<object> slotsToRemove = new List<object>();
                List<object> typesToRemove = new List<object>();
                foreach (object item in comboBoxSlotId.Items)
                {
                    if (!avaliableSlots.Contains(int.Parse(item.ToString())))
                    {
                        slotsToRemove.Add(item);
                    }
                }
                foreach (object item in comboBoxTypeOfRent.Items)
                {
                    if (item.ToString() != selectedTypeOfRent)
                    {
                        typesToRemove.Add(item);
                    }
                }
                foreach (object item in slotsToRemove)
                {
                    comboBoxSlotId.Items.Remove(item);
                }
                foreach (object item in typesToRemove)
                {
                    comboBoxTypeOfRent.Items.Remove(item);
                }
            }
        }

        private void iconButtonCreate_Click(object sender, EventArgs e)
        {
            CollectData();
        }

        private void CollectData()
        {
            int customerId = int.Parse(textBoxCustomerID.Text);
            string autoType = textBoxAutoType.Text;
            bool isRegularCustomer = false;
            string phoneNumber = maskedTextBox1.Text;
            int slotId = int.Parse(comboBoxSlotId.SelectedItem.ToString());
            string typeOfRent = comboBoxTypeOfRent.Text;
            int numOfExtends = int.Parse(textBoxNumOfExtends.Text);
            DateTime activationDate = DateTime.Now;

            Customer newCustomer = new Customer(autoType, isRegularCustomer, phoneNumber);
            newCustomer.INSERT();
            newCustomer.CreatePass(slotId, activationDate);
        }

        private void comboBoxSlotId_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }

        private void comboBoxTypeOfRent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxes();
        }
    }
}
