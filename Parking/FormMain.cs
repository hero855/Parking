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
using System.Runtime.InteropServices;

using FontAwesome.Sharp;
using Parking.Forms;
using Parking.Forms.Customers;
using System.Globalization;

namespace Parking
{
    public partial class FormMain : Form
    {
        //Fields
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormMain()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Icon = Properties.Resources.icon;
            UpdatePanels();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdatePanels();
        }
        // Updates
        private void UpdatePanels()
        {
            if (SqlFunctions.checkAllTables())
            {
                var nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
                nfi.NumberGroupSeparator = " ";

                int numOfAdvPasses = SqlFunctions.GetNumOfPassesByTypeOfRent("Subscribe \"Advanced\"");
                int priceOfAdvPass = SqlFunctions.GetPriceOfTypeOfRent("Subscribe \"Advanced\"");
                double avgAdvExteds = SqlFunctions.GetAvgExtendsOfPass("Subscribe \"Advanced\"");
                int advIncome = (int)(numOfAdvPasses * priceOfAdvPass * avgAdvExteds);
                labelAdvPanelNum.Text = numOfAdvPasses.ToString("#,0", nfi);
                labelAdvPanelIncome.Text = advIncome.ToString("#,0", nfi);
                labelAdvPanelAvgExtends.Text = avgAdvExteds.ToString("#,0.00", nfi);

                int numOfBasicPasses = SqlFunctions.GetNumOfPassesByTypeOfRent("Subscribe \"Basic\"");
                int priceOfBasicPass = SqlFunctions.GetPriceOfTypeOfRent("Subscribe \"Basic\"");
                double avgBasicExteds = SqlFunctions.GetAvgExtendsOfPass("Subscribe \"Basic\"");
                int basicIncome = (int)(numOfBasicPasses * priceOfBasicPass * avgBasicExteds);
                labelBasicPanelNum.Text = numOfBasicPasses.ToString("#,0", nfi);
                labelBasicPanelIncome.Text = basicIncome.ToString("#,0", nfi);
                labelBasicPanelAvgExtends.Text = avgAdvExteds.ToString("#,0.00", nfi);

                int numOfSinglePasses = SqlFunctions.GetNumOfPassesByTypeOfRent("Single");
                int priceOfSinglePass = SqlFunctions.GetPriceOfTypeOfRent("Single");
                double avgHours = SqlFunctions.GetAvgExtendsOfPass("Single");
                int singleIncome = (int)(numOfBasicPasses * priceOfSinglePass * avgHours);
                labelSinglePanelNum.Text = numOfSinglePasses.ToString("#,0", nfi);
                labelSinglePanelIncome.Text = singleIncome.ToString("#,0", nfi);
                labelSinglePanelAvgExtends.Text = avgHours.ToString("#,0.00", nfi);

                float sum = numOfAdvPasses + numOfBasicPasses + numOfSinglePasses;
                labelAdvPanelShare.Text = (100 * numOfAdvPasses / sum).ToString("#,0.00", nfi) + " %";
                labelBasicPanelShare.Text = (100 * numOfBasicPasses / sum).ToString("#,0.00", nfi) + " %";
                labelSinglePanelShare.Text = (100 * numOfSinglePasses / sum).ToString("#,0.00", nfi) + " %";

                labelGeneralIncome.Text = (advIncome + basicIncome + singleIncome).ToString("#,0", nfi) + " р.";
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(83, 184, 187);
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(235, 146, 190);
            public static Color color3 = Color.FromArgb(233, 137, 106);
            public static Color color4 = Color.FromArgb(131, 125, 192);
            public static Color color5 = Color.FromArgb(109, 152, 134);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 255, 50);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                leftBorderBtn.Visible = false;
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(35, 35, 35);
                currentBtn.IconColor = Color.White;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 51);
                currentBtn.IconColor = Color.Gainsboro;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.color0;
            lblTitleChildForm.Text = "Главная";
        }
        //Events
        //Reset
        private void iconButtonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            UpdatePanels();
        }
        //Menu Button_Clicks
        private void iconButtonPanking_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Parking.FormParking());
            panelMenuGroup1.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 60);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Парковка";
        }
        private void iconButtonFloors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormFloors());
            panelMenuSubGroup1.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Этажи";
        }
        private void iconButtonSlots_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.Slots.FormSlots());
            panelMenuSubGroup1.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Парковочные места";
        }
        private void iconButtonOther_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.Other.FormOther());
            panelMenuSubGroup1.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Другое";
        }
        private void iconButtonClients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormCustomers());
            panelMenuGroup2.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 60);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Клиенты";
        }
        private void iconButtonPasses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Forms.Passes.FormPasses());
            panelMenuSubGroup2.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Абонименты";
        }
        private void iconButtonPassesPlans_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new Forms.TypesOfRent.FormTypesOfRent());
            panelMenuSubGroup2.Controls.Add(leftBorderBtn);
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtn.BringToFront();
            leftBorderBtn.Visible = true;
            lblTitleChildForm.Text = "Виды аренды";
        }
        //DB Controls
        private void iconButtonGenerateData_Click(object sender, EventArgs e)
        {
            SqlFunctions.DeleteDataFromDB();
            SqlFunctions.GenerateTestData();
            UpdatePanels();
        }

        private void iconButtonDeleteDB_Click(object sender, EventArgs e)
        {
            SqlFunctions.DeleteDataFromDB();
            UpdatePanels();
        }

        private void iconButtonResetup_Click(object sender, EventArgs e)
        {
            SqlFunctions.DropLinks();
            SqlFunctions.DropTables();
            SqlFunctions.CreateTables();
            SqlFunctions.CreateLinks();
            UpdatePanels();
        }

        private void iconButtonAbout_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "AboutBox")
                {
                    return;
                }
            }
            new AboutBox().Show();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButtonMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void iconButtonMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}