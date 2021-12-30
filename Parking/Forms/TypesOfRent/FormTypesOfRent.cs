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

namespace Parking.Forms.TypesOfRent
{
    public partial class FormTypesOfRent : Form
    {
        public FormTypesOfRent()
        {
            InitializeComponent();
        }

        private void FormTypesOfRent_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dataGridViewTypesOfRent.Rows.Clear();
            List<TypeOfRent> typesOfRent = SqlFunctions.GetTypesOfRentFromDB();
            foreach (TypeOfRent typeOfRent in typesOfRent)
            {
                dataGridViewTypesOfRent.Rows.Add(typeOfRent.name, typeOfRent.price.ToString(), typeOfRent.unitOfMeasure);
            }
        }

        private void dataGridViewTypesOfRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridViewTypesOfRent.SelectedRows;
            if (rows.Count == 1)
            {
                DataGridViewRow row = rows[0];
                textBoxTypeOfRent.Text = row.Cells[0].Value.ToString();
                textBoxUnitsOfMeasure.Text = row.Cells[1].Value.ToString();
                textBoxPrice.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
