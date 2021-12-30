
namespace Parking.Forms.Floors
{
    partial class FormFloorsUPDATE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNumOfSlots = new System.Windows.Forms.TextBox();
            this.textBoxFloorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonClear = new FontAwesome.Sharp.IconButton();
            this.comboBoxPassesPlans = new System.Windows.Forms.ComboBox();
            this.iconButtonINSERT = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.iconButtonShowcase = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewFloors = new System.Windows.Forms.DataGridView();
            this.FloorsColumnFloorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorsColumnNumOfSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorsColumnPassPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFloorsTableTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.SlotsColumnSlotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotsColumnFloorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotsColumnCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotsColumnIsBusy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumOfSlots
            // 
            this.textBoxNumOfSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumOfSlots.Location = new System.Drawing.Point(332, 115);
            this.textBoxNumOfSlots.Name = "textBoxNumOfSlots";
            this.textBoxNumOfSlots.Size = new System.Drawing.Size(157, 26);
            this.textBoxNumOfSlots.TabIndex = 15;
            // 
            // textBoxFloorID
            // 
            this.textBoxFloorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFloorID.Location = new System.Drawing.Point(332, 68);
            this.textBoxFloorID.Name = "textBoxFloorID";
            this.textBoxFloorID.Size = new System.Drawing.Size(157, 26);
            this.textBoxFloorID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "Требуемый план\r\nабонимента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер этажа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Количество мест:";
            // 
            // iconButtonClear
            // 
            this.iconButtonClear.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonClear.IconColor = System.Drawing.SystemColors.WindowText;
            this.iconButtonClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClear.IconSize = 20;
            this.iconButtonClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonClear.Location = new System.Drawing.Point(401, 17);
            this.iconButtonClear.Name = "iconButtonClear";
            this.iconButtonClear.Size = new System.Drawing.Size(88, 32);
            this.iconButtonClear.TabIndex = 20;
            this.iconButtonClear.Text = "Очистить";
            this.iconButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClear.UseVisualStyleBackColor = false;
            // 
            // comboBoxPassesPlans
            // 
            this.comboBoxPassesPlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPassesPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxPassesPlans.FormattingEnabled = true;
            this.comboBoxPassesPlans.ItemHeight = 20;
            this.comboBoxPassesPlans.Location = new System.Drawing.Point(332, 161);
            this.comboBoxPassesPlans.Name = "comboBoxPassesPlans";
            this.comboBoxPassesPlans.Size = new System.Drawing.Size(157, 28);
            this.comboBoxPassesPlans.TabIndex = 17;
            // 
            // iconButtonINSERT
            // 
            this.iconButtonINSERT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonINSERT.IconColor = System.Drawing.Color.Green;
            this.iconButtonINSERT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonINSERT.IconSize = 20;
            this.iconButtonINSERT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonINSERT.Location = new System.Drawing.Point(548, 133);
            this.iconButtonINSERT.Name = "iconButtonINSERT";
            this.iconButtonINSERT.Size = new System.Drawing.Size(117, 32);
            this.iconButtonINSERT.TabIndex = 19;
            this.iconButtonINSERT.Text = "Добавить";
            this.iconButtonINSERT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonINSERT.UseVisualStyleBackColor = false;
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(78, 208);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 16;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            // 
            // iconButtonShowcase
            // 
            this.iconButtonShowcase.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonShowcase.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonShowcase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonShowcase.IconSize = 20;
            this.iconButtonShowcase.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonShowcase.Location = new System.Drawing.Point(548, 84);
            this.iconButtonShowcase.Name = "iconButtonShowcase";
            this.iconButtonShowcase.Size = new System.Drawing.Size(117, 32);
            this.iconButtonShowcase.TabIndex = 21;
            this.iconButtonShowcase.Text = "Сгенерировать";
            this.iconButtonShowcase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonShowcase.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(78, 246);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(644, 212);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFloors);
            this.panel2.Controls.Add(this.labelFloorsTableTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 212);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewFloors
            // 
            this.dataGridViewFloors.AllowUserToAddRows = false;
            this.dataGridViewFloors.AllowUserToDeleteRows = false;
            this.dataGridViewFloors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFloors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFloors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFloors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FloorsColumnFloorId,
            this.FloorsColumnNumOfSlots,
            this.FloorsColumnPassPlan});
            this.dataGridViewFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFloors.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewFloors.Name = "dataGridViewFloors";
            this.dataGridViewFloors.ReadOnly = true;
            this.dataGridViewFloors.RowHeadersVisible = false;
            this.dataGridViewFloors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFloors.Size = new System.Drawing.Size(317, 182);
            this.dataGridViewFloors.TabIndex = 1;
            // 
            // FloorsColumnFloorId
            // 
            this.FloorsColumnFloorId.HeaderText = "Номер этажа";
            this.FloorsColumnFloorId.Name = "FloorsColumnFloorId";
            this.FloorsColumnFloorId.ReadOnly = true;
            this.FloorsColumnFloorId.Width = 70;
            // 
            // FloorsColumnNumOfSlots
            // 
            this.FloorsColumnNumOfSlots.HeaderText = "Количество мест";
            this.FloorsColumnNumOfSlots.Name = "FloorsColumnNumOfSlots";
            this.FloorsColumnNumOfSlots.ReadOnly = true;
            this.FloorsColumnNumOfSlots.Width = 95;
            // 
            // FloorsColumnPassPlan
            // 
            this.FloorsColumnPassPlan.HeaderText = "Требуемый план абонимента";
            this.FloorsColumnPassPlan.Name = "FloorsColumnPassPlan";
            this.FloorsColumnPassPlan.ReadOnly = true;
            this.FloorsColumnPassPlan.Width = 120;
            // 
            // labelFloorsTableTitle
            // 
            this.labelFloorsTableTitle.BackColor = System.Drawing.Color.Silver;
            this.labelFloorsTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFloorsTableTitle.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloorsTableTitle.ForeColor = System.Drawing.Color.Black;
            this.labelFloorsTableTitle.Location = new System.Drawing.Point(0, 0);
            this.labelFloorsTableTitle.Name = "labelFloorsTableTitle";
            this.labelFloorsTableTitle.Size = new System.Drawing.Size(317, 30);
            this.labelFloorsTableTitle.TabIndex = 0;
            this.labelFloorsTableTitle.Text = "Этажи";
            this.labelFloorsTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSlots);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 212);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.AllowUserToAddRows = false;
            this.dataGridViewSlots.AllowUserToDeleteRows = false;
            this.dataGridViewSlots.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlotsColumnSlotId,
            this.SlotsColumnFloorId,
            this.SlotsColumnCustomerId,
            this.SlotsColumnIsBusy});
            this.dataGridViewSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSlots.Location = new System.Drawing.Point(0, 56);
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.ReadOnly = true;
            this.dataGridViewSlots.RowHeadersVisible = false;
            this.dataGridViewSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlots.Size = new System.Drawing.Size(323, 156);
            this.dataGridViewSlots.TabIndex = 13;
            // 
            // SlotsColumnSlotId
            // 
            this.SlotsColumnSlotId.HeaderText = "Номер места";
            this.SlotsColumnSlotId.Name = "SlotsColumnSlotId";
            this.SlotsColumnSlotId.ReadOnly = true;
            this.SlotsColumnSlotId.Width = 70;
            // 
            // SlotsColumnFloorId
            // 
            this.SlotsColumnFloorId.HeaderText = "Номер этажа";
            this.SlotsColumnFloorId.Name = "SlotsColumnFloorId";
            this.SlotsColumnFloorId.ReadOnly = true;
            this.SlotsColumnFloorId.Width = 70;
            // 
            // SlotsColumnCustomerId
            // 
            this.SlotsColumnCustomerId.HeaderText = "Номер клиента";
            this.SlotsColumnCustomerId.Name = "SlotsColumnCustomerId";
            this.SlotsColumnCustomerId.ReadOnly = true;
            this.SlotsColumnCustomerId.Width = 73;
            // 
            // SlotsColumnIsBusy
            // 
            this.SlotsColumnIsBusy.HeaderText = "Занято";
            this.SlotsColumnIsBusy.Name = "SlotsColumnIsBusy";
            this.SlotsColumnIsBusy.ReadOnly = true;
            this.SlotsColumnIsBusy.Width = 68;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Подченённая таблица:\r\nПарковочные места";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFloorsUPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.iconButtonShowcase);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.iconButtonINSERT);
            this.Controls.Add(this.comboBoxPassesPlans);
            this.Controls.Add(this.iconButtonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFloorID);
            this.Controls.Add(this.textBoxNumOfSlots);
            this.Name = "FormFloorsUPDATE";
            this.Text = "FormFloorsUPDATE";
            this.Load += new System.EventHandler(this.FormFloorsUPDATE_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumOfSlots;
        private System.Windows.Forms.TextBox textBoxFloorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonClear;
        private System.Windows.Forms.ComboBox comboBoxPassesPlans;
        private FontAwesome.Sharp.IconButton iconButtonINSERT;
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private FontAwesome.Sharp.IconButton iconButtonShowcase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnFloorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnNumOfSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnPassPlan;
        private System.Windows.Forms.Label labelFloorsTableTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnSlotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnFloorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnIsBusy;
        private System.Windows.Forms.Label label4;
    }
}