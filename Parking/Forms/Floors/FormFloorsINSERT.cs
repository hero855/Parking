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

namespace Parking.Forms.Floors
{
    public partial class FormFloorsINSERT : Form
    {
        Floor floor;
        FormFloors parent;

        bool generated;
        bool showcase;

        public FormFloorsINSERT(FormFloors parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.floor = parent.floor;
        }

        private void FormFloorsINSERT_Load(object sender, EventArgs e)
        {
            generated = false;
            showcase = false;
            textBoxFloorID.Text = (SqlFunctions.GetLastFloorIDInDB() + 1).ToString();
            UpdateTables();
            UpdatePassesPlansCombobox();
        }
        //
        // Updates
        //
        public void UpdateTables()
        {
            List<Floor> floors = SqlFunctions.GetFloorsFromDB();
            foreach (Floor floor in floors)
            {
                dataGridViewSlots.Rows.Add(floor.id, floor.numOfSlots, floor.typeOfRent);
            }

            List<Slot> slots = SqlFunctions.GetSlotsFromDB();
            foreach (Slot slot in slots)
            {
                dataGridViewSlots.Rows.Add(slot.id, slot.floorId, slot.isBusy);
            }
        }

        private void UpdatePassesPlansCombobox()
        {
            List<string> PlansNames = new List<string>();
            using (var conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT [Название плана] FROM dbo.[Планы абониментов] ORDER BY [Стоимость (руб.)] ASC;";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PlansNames.Add(reader[0].ToString());
                    }
                }
            }
            comboBoxPassesPlans.DataSource = PlansNames;
        }
        //
        // Functions idk
        //
        private void collectData()
        {
            try
            {
                floor.id = int.Parse(textBoxFloorID.Text);
            }
            catch
            {
                Messages.sendErrorInputMessage("номер нового этажа");
                return;
            }
            try
            {
                floor.numOfSlots = int.Parse(textBoxNumOfSlots.Text);
            }
            catch
            {
                Messages.sendErrorInputMessage("количество парковочных мест");
                return;
            }
            floor.typeOfRent = comboBoxPassesPlans.Text;
        }
        //
        // Click events
        //
        private void iconButtonINSERT_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonShowGenerate_Click(object sender, EventArgs e)
        {
            dataGridViewSlots.Rows.Clear();
            UpdateTables();
            List<Slot> slots = floor.generateSlots();
            foreach (Slot slot in slots)
            {
                dataGridViewSlots.Rows.Add(slot.id, slot.floorId, slot.isBusy);
            }
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {

        }
        //
        // DataGrigView formatng
        //

        private void dataGridViewFloors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool inSlots;

            if (generated)
            {
                DataGridViewRow row = dataGridViewSlots.Rows[e.RowIndex];
                int slotID = int.Parse(row.Cells[0].Value.ToString());
                inSlots = false;
                foreach (Slot slot in floor.generateSlots())
                {
                    if (slot.id == slotID)
                    {
                        inSlots = true;
                        break;
                    }
                }
            }
            else
            {
                inSlots = false;
            }

            Color col = Functions.getCellColor(e, dataGridViewSlots);

            if (inSlots)
            {
                col = Functions.makeGreener(col, 20);
            }

            e.CellStyle.BackColor = col;
        }
        //
        // KeyPress
        //
        private void textBoxFloorID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNumOfSlots_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void iconButtonShowcase_Click(object sender, EventArgs e)
        {

        }
    }
}
