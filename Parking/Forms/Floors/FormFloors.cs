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
using Parking.Forms.Floors;
using Parking.objects;

namespace Parking.Forms
{ 
    public partial class FormFloors : Form
    {
        public Floor floor;

        public FormFloors()
        {
            InitializeComponent();
        }

        private void FormFloors_Load(object sender, EventArgs e)
        {
            UpdateTables();
            UpdatePassesPlansCombobox();
            DataGridViewSelectedRowCollection selectedRows = this.dataGridViewFloors.SelectedRows;
            if (selectedRows.Count == 1)
            {
                DataGridViewRow row = selectedRows[0];
                textBoxFloorID.Text = row.Cells[0].Value.ToString();
                textBoxNumOfSlots.Text = row.Cells[1].Value.ToString();
                comboBoxTypesOfRent.Text = row.Cells[2].Value.ToString();
            }
        }
        //
        // Functions?!
        //
        private void CollectData()
        {
            int id, numOfSlots;
            string passPlan;
            id = int.Parse(textBoxFloorID.Text);
            numOfSlots = int.Parse(textBoxNumOfSlots.Text);
            passPlan = comboBoxTypesOfRent.Text;
            this.floor = new Floor(id, numOfSlots, passPlan);
        }
        //
        // Updates
        //
        public void UpdateTables()
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewFloors.SelectedRows;
            int selectedRowId = 0;
            bool oneRow = selectedRows.Count == 1;
            if (oneRow)
            {
                selectedRowId = selectedRows[0].Index;
            }
            dataGridViewFloors.Rows.Clear();
            List<Floor> floors = SqlFunctions.GetFloorsFromDB();
            foreach (Floor floor in floors)
            {
                dataGridViewFloors.Rows.Add(floor.id, floor.numOfSlots, floor.typeOfRent);
            }
            if (oneRow)
            {
                dataGridViewFloors.Rows[0].Selected = false;
                dataGridViewFloors.Rows[selectedRowId].Selected = true;
            }
        }

        private void UpdatePassesPlansCombobox()
        {
            foreach (TypeOfRent typeOfRent in SqlFunctions.GetTypesOfRentFromDB())
            {
                comboBoxTypesOfRent.Items.Add(typeOfRent.name);
            }
        }
        //
        // Clicks events
        //
        private void iconButtonUPDATE_Click(object sender, EventArgs e)
        {
            CollectData();
            floor.UPDATE();
            UpdateTables();
        }

        private void iconButtonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTables();
        }
        //
        // Autofill textboxes
        //
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewFloors.Rows[e.RowIndex];
                textBoxFloorID.Text = row.Cells[0].Value.ToString();
                textBoxNumOfSlots.Text = row.Cells[1].Value.ToString();
                comboBoxTypesOfRent.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Functions.getCellColor(e, dataGridViewFloors);
        }
    }
}
