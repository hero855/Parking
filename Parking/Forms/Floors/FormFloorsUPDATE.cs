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
    public partial class FormFloorsUPDATE : Form
    {
        readonly Floor floor;
        readonly bool generated;
        readonly FormFloors parent;

        List<Slot> slotsToUpdate;

        public FormFloorsUPDATE(FormFloors parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.floor = parent.floor;
        }

        private void FormFloorsUPDATE_Load(object sender, EventArgs e)
        {
            UpdateTables();
            UpdatePassesPlansCombobox();
            fillFloorData();
            slotsToUpdate = floor.generateSlots();
            showcaseUpdate();
        }
        //
        // Updates
        //
        private void UpdateTables()
        {
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
        // just Functions
        //
        private void CollectData()
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

        private void fillFloorData()
        {
            textBoxFloorID.Text = this.floor.id.ToString();
            textBoxNumOfSlots.Text = this.floor.numOfSlots.ToString();
            comboBoxPassesPlans.Text = this.floor.typeOfRent;
        }

        private void showcaseUpdate()
        {
            foreach (Slot slot in slotsToUpdate)
            {
                slot.floorId = this.floor.id;
            }
        }
        //
        // Clicks
        //
        private void iconButtonUPDATE_Click(object sender, EventArgs e)
        {
            CollectData();
            try
            {
                floor.UPDATE();

                List<Slot> slots = floor.generateSlots();
                foreach (Slot slot in slots)
                {
                    slot.UPDATE();
                }
                Messages.sendSuccsessMessage();
            }
            catch (Exception ex)
            {
                Messages.sendFailedMessage(ex);
            }
            parent.UpdateTables();
            Close();
        }

        private void iconButtonShowcase_Click(object sender, EventArgs e)
        {
            this.slotsToUpdate = floor.generateSlots();
            showcaseUpdate();
        }

        private void iconButtonClear_Click(object sender, EventArgs e)
        {
            textBoxFloorID.Clear();
            textBoxNumOfSlots.Clear();
            comboBoxPassesPlans.Text = "Не нежен";
        }
        //
        // DataGrigView formatng
        //
        private void dataGridViewFloors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Color defaultColor = Color.White;
            Color selectColor = Functions.makeDarker(Color.LightBlue, -25);

            DataGridViewRow row = dataGridViewFloors.Rows[e.RowIndex];
            int rowID = row.Index;
            bool idIsEven = rowID % 2 == 0;
            int floorID = int.Parse(row.Cells[0].Value.ToString());

            Color col;
            if (floorID == this.floor.id)
            {
                col = selectColor;
            }
            else
            {
                col = defaultColor;
            }
            if (idIsEven)
            {
                col = Functions.makeDarker(col, 20);
            }
            if (e.Value is null)
            {
                e.Value = "NULL";
                col = Functions.makeYellowed(col, 20);
            }
            e.CellStyle.BackColor = col;
        }

        private void dataGridViewSlots_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Color defaultColor = Color.White;
            Color selectColor = Functions.makeDarker(Color.LightBlue, -25);

            DataGridViewRow row = dataGridViewSlots.Rows[e.RowIndex];
            int rowID = row.Index;

            bool idIsEven = rowID % 2 == 0;
            bool inSlots;

            if (generated)
            {
                int slotID = int.Parse(row.Cells[0].Value.ToString());
                inSlots = false;
                List<Slot> slots = floor.generateSlots();
                foreach (Slot slot in slots)
                {
                    if (slot.id == slotID && e.RowIndex != 0)
                    {
                        inSlots = true;
                        string colName = dataGridViewSlots.Columns[e.ColumnIndex].HeaderText;
                        if (colName == "Номер этажа")
                        {
                            e.Value = string.Format("{0} -> {1}", e.Value.ToString(), slots[e.RowIndex + 1 - slots[0].id].floorId);
                        }
                    }
                }
            }
            else
            {
                inSlots = false;
            }
            Color col;
            if (inSlots)
            {
                col = selectColor;
            }
            else
            {
                col = defaultColor;
            }
            if (idIsEven)
            {
                col = Functions.makeDarker(col, 20);
            }
            if (e.Value is null)
            {
                e.Value = "NULL";
                col = Functions.makeYellowed(col, 20);
            }
            e.CellStyle.BackColor = col;
        }
        //
        // Key handlers
        //
        private void textBoxFloorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumOfSlots_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormFloorsUPDATE_Load_1(object sender, EventArgs e)
        {

        }
    }
}
