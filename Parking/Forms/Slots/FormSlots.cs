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
using System.Data.SqlTypes;
using Parking.objects;

namespace Parking.Forms.Slots
{
    public partial class FormSlots : Form
    {
        public FormSlots()
        {
            InitializeComponent();
            UpdateTables();
            dataGridViewSlots.Rows[0].Selected = true;
            UpdateTextboxes();
        }
        //
        // Updates
        //
        private void UpdateTables()
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewSlots.SelectedRows;
            int selectedRowId = 0;
            bool oneRow = selectedRows.Count == 1;
            if (oneRow)
            {
                selectedRowId = selectedRows[0].Index;
            }
            dataGridViewSlots.Rows.Clear();
            List<Slot> slots = SqlFunctions.GetSlotsFromDB();
            foreach (Slot slot in slots)
            {
                dataGridViewSlots.Rows.Add(slot.id, slot.floorId, slot.isBusy);
            }
            if (oneRow)
            {
                dataGridViewSlots.Rows[0].Selected = false;
                dataGridViewSlots.Rows[selectedRowId].Selected = true;
            }
        }

        private void UpdateTextboxes()
        {
            DataGridViewSelectedRowCollection rows = this.dataGridViewSlots.SelectedRows;
            if (rows.Count == 1)
            {
                DataGridViewRow row = rows[0];
                textBoxSlotID.Text = row.Cells[0].Value.ToString();
                textBoxFloorID.Text = row.Cells[1].Value.ToString();
                checkBoxIsBusy.Checked = bool.Parse(row.Cells[2].Value.ToString());
            }
        }
        //
        // DataGridView
        //
        private void dataGridViewSlots_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Functions.getCellColor(e, dataGridViewSlots);
        }

        private void dataGridViewSlots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateTextboxes();
            }
        }

        private void iconButtonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTables();
        }
    }
}
