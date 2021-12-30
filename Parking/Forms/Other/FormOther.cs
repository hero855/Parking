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

namespace Parking.Forms.Other
{
    public partial class FormOther : Form
    {
        public FormOther()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewUnitsOfMeasure.Rows.Clear();
            foreach (UnitOfMeasure unitOfMeasure in SqlFunctions.GetUnitsOfMeasureFromDB())
            {
                dataGridViewUnitsOfMeasure.Rows.Add(unitOfMeasure.unitOfMeasure);
            }
        }

        private void dataGridViewUnitsOfMeasure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridViewUnitsOfMeasure.SelectedRows;
            if (rows.Count == 1) {
                DataGridViewRow row = rows[0];
                textBoxUnitOfMeasure.Text = row.Cells[0].Value.ToString();
            } 
        }

        private void iconButtonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
