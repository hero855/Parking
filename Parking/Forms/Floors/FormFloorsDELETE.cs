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
    public partial class FormFloorsDELETE : Form
    {
        Floor floor;
        bool generated;

        FormFloors parent;

        public FormFloorsDELETE(FormFloors parent)
        {
            InitializeComponent();
            this.floor = parent.floor;
            textBoxFloorID.Text = floor.id.ToString();
            floor.generateSlots();
            this.parent = parent;
        }

        private void FormFloorsDELETE_Load(object sender, EventArgs e)
        {
            UpdateTables();
        }

        private void FormFloorsINSERT_Load(object sender, EventArgs e)
        {
            generated = false;
        }
        //
        // Updates
        //
        private void UpdateTables()
        {
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
        }

        //
        // Click events
        //
        private void iconButtonDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                collectData();
            }
            catch (Exception ex)
            {
                Messages.sendFailedMessage(ex);
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
            Color defaultColor = Color.White;
            Color selectColor = Color.MistyRose;

            DataGridViewRow row = dataGridViewFloors.Rows[e.RowIndex];
            int rowID = row.Index;
            bool idIsEven = rowID % 2 == 0;
            int floorID = int.Parse(row.Cells[0].Value.ToString());

            Color col;
            if (floorID == floor.id)
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
                col = Functions.makeReder(col, 20);
            }
            e.CellStyle.BackColor = col;
        }
    }
}
