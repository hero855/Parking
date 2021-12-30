using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Forms.Passes
{
    public partial class FormSlotSelect : Form
    {
        private string typeOfRent;
        public int slotId;
        public bool slotSelected;
        Form parent;

        public FormSlotSelect(FormPasses parent, string typeOfRent)
        {
            InitializeComponent();
            this.typeOfRent = typeOfRent;
            UpdateTable();
            this.parent = parent;
            slotSelected = false;
        }

        private void UpdateTable()
        {
            comboBoxSlotId.Items.Clear();
            List<int> slotIds = new List<int>();
            foreach (int slotId in SqlFunctions.GetAvalibleSlotsId(typeOfRent))
            {
                slotIds.Add(slotId);
            }
            slotIds.Sort();
            foreach (int slotId in slotIds)
            {
                comboBoxSlotId.Items.Add(slotId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slotId = int.Parse(comboBoxSlotId.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
