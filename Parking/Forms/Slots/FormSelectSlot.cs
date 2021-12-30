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

namespace Parking.Forms.Slots
{
    public partial class FormSelectSlot : Form
    {
        private string typeOfRent;
        public int slotId;

        public FormSelectSlot(string typeOfRent)
        {
            InitializeComponent();
            this.typeOfRent = typeOfRent;
            UpdateTable();
        }

        private void UpdateTable()
        {
            comboBoxSlotId.Items.Clear();
            List<int> slotIds = new List<int>();
            foreach (int slotId in SqlFunctions.getAvalibleSlotsId(typeOfRent))
            {
                slotIds.Add(slotId);
            }
            slotIds.Sort();
            foreach (int slotId in slotIds)
            {
                comboBoxSlotId.Items.Add(slotId);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            this.slotId = int.Parse(comboBoxSlotId.Text);
            this.Close();
        }
    }
}
