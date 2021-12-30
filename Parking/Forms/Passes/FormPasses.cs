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
using System.Globalization;
using System.Data.SqlClient;

namespace Parking.Forms.Passes
{
    public partial class FormPasses : Form
    {
        Pass pass;

        public FormPasses()
        {
            InitializeComponent();
        }

        private void FormPasses_Load(object sender, EventArgs e)
        {
            UpdateTable();
            UpdateTextBoxes(0);
            UpdateComboBoxes();
            DataGridViewSelectedRowCollection selectedRows = this.dataGridViewPasses.SelectedRows;
        }
        //
        // Updates
        //
        private void UpdateTable()
        {
            dataGridViewPasses.Rows.Clear();

            string fmt1 = "dd MMM yyyy";
            string fmt2 = "HH:mm, dd MMM yyyy";
            List<Pass> passes = SqlFunctions.GetPassesFromDB();
            foreach (Pass pass in passes)
            {
                switch (pass.getUnitsOfMeasure())
                {
                    case "rpm":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt1), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                    case "rph":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt2), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                }
            }
        }

        private void UpdateComboBoxes()
        {
            CollectData();
            comboBoxSlotId.Items.Clear();               
            List<int> slotIds = new List<int>();
            foreach (int slotId in SqlFunctions.GetAvalibleSlotsId(pass.typeOfRent))
            {
                slotIds.Add(slotId);
            }
            DataGridViewSelectedRowCollection rows = dataGridViewPasses.SelectedRows;
            if (rows.Count == 1)
            {
                DataGridViewRow row = rows[0];
                slotIds.Add(int.Parse(row.Cells[2].Value.ToString()));
            }
            slotIds.Sort();
            foreach (int slotId in slotIds)
            {
                comboBoxSlotId.Items.Add(slotId.ToString());
            }
            comboBoxTypeOfRent.Items.Clear();
            foreach (TypeOfRent typeOfRent in SqlFunctions.GetTypesOfRentFromDB())
            {
                comboBoxTypeOfRent.Items.Add(typeOfRent.name);
            }
        }

        private void UpdateTextBoxes(int index)
        {
            if (index >= 0 && dataGridViewPasses.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewPasses.Rows[index];
                textBoxPassID.Text = row.Cells[0].Value.ToString();
                textBoxCustomerId.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value == null)
                {
                    comboBoxSlotId.Text = "Отсутствует";
                }
                else
                {
                    comboBoxSlotId.Text = row.Cells[2].Value.ToString();
                }
                comboBoxTypeOfRent.Text = row.Cells[3].Value.ToString();
                textBoxActivationDate.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value != null)
                {
                    textBoxDiactivationDate.Text = row.Cells[5].Value.ToString();
                }
                else
                {
                    textBoxDiactivationDate.Text = "Отсутствует";
                }
                textBoxNumOfExtends.Text = row.Cells[6].Value.ToString();
            }
        }

        private void CollectData()
        {
            int index;
            DataGridViewSelectedRowCollection rows = dataGridViewPasses.SelectedRows;
            if (rows.Count == 1)
            {
                DataGridViewRow row = rows[0];
                if (dataGridViewPasses.Rows.Count > 0)
                {
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    int customerId = int.Parse(row.Cells[1].Value.ToString());
                    int slotId;
                    slotId = int.Parse(row.Cells[2].Value.ToString());
                    string typeOfRent = row.Cells[3].Value.ToString();
                    DateTime activationDate = DateTime.Parse(row.Cells[4].Value.ToString());
                    int numOfExtends = int.Parse(row.Cells[6].Value.ToString());
                    pass = new Pass(id, customerId, slotId, typeOfRent, activationDate, numOfExtends);
                }
            }
        }

        private void UpdateTablesWithSelectingSave()
        {
            int selectedRowId;
            DataGridViewSelectedRowCollection rows = dataGridViewPasses.SelectedRows;
            if (rows.Count == 1)
            {
                selectedRowId = rows[0].Index;
            }
            else
            {
                selectedRowId = 0;
            }
            UpdateTable();
            dataGridViewPasses.Rows[0].Selected = false;
            dataGridViewPasses.Rows[selectedRowId].Selected = true;
            UpdateTextBoxes(selectedRowId);
        }
        //
        // KLEEEE ks events
        //
        private void iconButtonExtendRent_Click(object sender, EventArgs e)
        {
            CollectData();
            if (pass.getUnitsOfMeasure() == "rpm")
            {
                CollectData();
                pass.extendRent(1);
                UpdateTablesWithSelectingSave();
            }
            else
            {
                Messages.sendErrorMessage("Разовые подписки нельзя продливать");
            }
        }

        private void iconButtonUPDATESlot_Click(object sender, EventArgs e)
        {
            CollectData();
            pass.slotId = int.Parse(comboBoxSlotId.Text);
            pass.UPDATE();
            UpdateTablesWithSelectingSave();
        }

        private void iconButtonUPDATEPlan_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();
                string typeOfRent = comboBoxTypeOfRent.Text;
                pass.typeOfRent = typeOfRent;
                List<int> slots = SqlFunctions.GetSlotIdsByTypeOfRent(typeOfRent);
                int slotId = int.Parse(comboBoxSlotId.Text);
                if (!slots.Contains(slotId))
                {
                    FormSlotSelect frm = new FormSlotSelect(this, typeOfRent);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        slotId = frm.slotId;
                    }
                }
                pass.slotId = slotId;
                pass.UPDATE();
                UpdateTablesWithSelectingSave();
                UpdateComboBoxes();
            }
            catch
            {
                Messages.sendErrorInputMessage("данные о абонименте");
            }
        }

        private void iconButtonUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTablesWithSelectingSave();
        }
        //
        // DataGridView
        //
        private void dataGridViewPasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateComboBoxes();
            UpdateTextBoxes(e.RowIndex);
        }

        private void dataGridViewPasses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = Functions.getCellColor(e, dataGridViewPasses);
        }

        private void iconButtonFilterBy_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FormPassesFilterBy")
                {
                    return;
                }
            }
            new FormPassesFilterBy(this).Show();
        }

        public void ShowFiltered(string query) 
        {
            List<Pass> filteredPasses = new List<Pass>();
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int passId, customerId, numOfExtends;
                    int? slotId;
                    DateTime activationDate;
                    string planName;
                    while (reader.Read())
                    {
                        passId = int.Parse(reader[0].ToString());
                        customerId = int.Parse(reader[1].ToString());
                        if (reader[2] == DBNull.Value)
                        {
                            slotId = null;
                        }
                        else
                        {
                            slotId = int.Parse(reader[2].ToString());
                        }
                        planName = reader[3].ToString();
                        activationDate = reader.GetDateTime(4);
                        numOfExtends = int.Parse(reader[6].ToString());
                        Pass pass = new Pass(passId, customerId, slotId, planName, activationDate, numOfExtends);
                        filteredPasses.Add(pass);
                    }
                }
            }

            dataGridViewPasses.Rows.Clear();

            string fmt1 = "dd MMM yyyy";
            string fmt2 = "HH:mm, dd MMM yyyy";
            foreach (Pass pass in filteredPasses)
            {
                switch (pass.getUnitsOfMeasure())
                {
                    case "rpm":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt1), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                    case "rph":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt2), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                }
            }
        }

        private void iconButtonSortBy_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "FormPassesSortBy")
                {
                    return;
                }
            }
            FormPassesSortBy sortFrm = new FormPassesSortBy(this);
            sortFrm.Show();
        }
        
        public void showSorted(string column, string order)
        { 
            if (order == "По убыванию")
            {
                order = "DESC";
            }
            else
            {
                order = "ASC";
            }
            List<Pass> sortedPasses = new List<Pass>();
            using (SqlConnection conn = new SqlConnection(SqlFunctions.ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Абонименты] ORDER BY ";
                query += "[" + column + "] " + order + ";";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int passId, customerId, numOfExtends;
                    int? slotId;
                    DateTime activationDate;
                    string planName;
                    while (reader.Read())
                    {
                        passId = int.Parse(reader[0].ToString());
                        customerId = int.Parse(reader[1].ToString());
                        if (reader[2] == DBNull.Value)
                        {
                            slotId = null;
                        }
                        else
                        {
                            slotId = int.Parse(reader[2].ToString());
                        }
                        planName = reader[3].ToString();
                        activationDate = reader.GetDateTime(4);
                        numOfExtends = int.Parse(reader[6].ToString());
                        Pass pass = new Pass(passId, customerId, slotId, planName, activationDate, numOfExtends);
                        sortedPasses.Add(pass);
                    }
                }
            }

            dataGridViewPasses.Rows.Clear();

            string fmt1 = "dd MMM yyyy";
            string fmt2 = "HH:mm, dd MMM yyyy";
            foreach (Pass pass in sortedPasses)
            {
                switch (pass.getUnitsOfMeasure())
                {
                    case "rpm":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt1), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                    case "rph":
                        dataGridViewPasses.Rows.Add(pass.id, pass.customerId, pass.slotId, pass.typeOfRent, pass.activationDate.ToString(fmt2), pass.diactivationDate?.ToString(fmt1), pass.numOfExtends);
                        break;
                }
            }
        }
    }
}
