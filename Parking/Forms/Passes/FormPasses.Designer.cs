
namespace Parking.Forms.Passes
{
    partial class FormPasses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iconButtonSortBy = new FontAwesome.Sharp.IconButton();
            this.iconButtonFilterBy = new FontAwesome.Sharp.IconButton();
            this.textBoxDiactivationDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxPassID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxActivationDate = new System.Windows.Forms.TextBox();
            this.comboBoxSlotId = new System.Windows.Forms.ComboBox();
            this.textBoxNumOfExtends = new System.Windows.Forms.TextBox();
            this.iconButtonUPDATESlot = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonExtendRent = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButtonUPDATEPlan = new FontAwesome.Sharp.IconButton();
            this.comboBoxTypeOfRent = new System.Windows.Forms.ComboBox();
            this.dataGridViewPasses = new System.Windows.Forms.DataGridView();
            this.PassesColumnPassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnSlotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnTypeOfRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnActivationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnDiactivationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassesColumnNumOfExtends = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(53, 20);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 4;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            this.iconButtonUpdateTable.Click += new System.EventHandler(this.iconButtonUpdateTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 295);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.iconButtonSortBy);
            this.splitContainer1.Panel1.Controls.Add(this.iconButtonFilterBy);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDiactivationDate);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCustomerId);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPassID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxActivationDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSlotId);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNumOfExtends);
            this.splitContainer1.Panel2.Controls.Add(this.iconButtonUPDATESlot);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.iconButtonExtendRent);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.iconButtonUPDATEPlan);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTypeOfRent);
            this.splitContainer1.Size = new System.Drawing.Size(833, 295);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 20;
            // 
            // iconButtonSortBy
            // 
            this.iconButtonSortBy.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonSortBy.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonSortBy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSortBy.IconSize = 20;
            this.iconButtonSortBy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonSortBy.Location = new System.Drawing.Point(697, 28);
            this.iconButtonSortBy.Name = "iconButtonSortBy";
            this.iconButtonSortBy.Size = new System.Drawing.Size(111, 35);
            this.iconButtonSortBy.TabIndex = 22;
            this.iconButtonSortBy.Text = "Сортировка";
            this.iconButtonSortBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSortBy.UseVisualStyleBackColor = true;
            this.iconButtonSortBy.Click += new System.EventHandler(this.iconButtonSortBy_Click);
            // 
            // iconButtonFilterBy
            // 
            this.iconButtonFilterBy.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButtonFilterBy.IconColor = System.Drawing.Color.Black;
            this.iconButtonFilterBy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFilterBy.IconSize = 20;
            this.iconButtonFilterBy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonFilterBy.Location = new System.Drawing.Point(697, 76);
            this.iconButtonFilterBy.Name = "iconButtonFilterBy";
            this.iconButtonFilterBy.Size = new System.Drawing.Size(111, 35);
            this.iconButtonFilterBy.TabIndex = 21;
            this.iconButtonFilterBy.Text = "Фильтрация";
            this.iconButtonFilterBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFilterBy.UseVisualStyleBackColor = true;
            this.iconButtonFilterBy.Click += new System.EventHandler(this.iconButtonFilterBy_Click);
            // 
            // textBoxDiactivationDate
            // 
            this.textBoxDiactivationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDiactivationDate.Location = new System.Drawing.Point(408, 79);
            this.textBoxDiactivationDate.Name = "textBoxDiactivationDate";
            this.textBoxDiactivationDate.ReadOnly = true;
            this.textBoxDiactivationDate.Size = new System.Drawing.Size(157, 26);
            this.textBoxDiactivationDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер\r\nабонимента:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCustomerId.Location = new System.Drawing.Point(171, 79);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.ReadOnly = true;
            this.textBoxCustomerId.Size = new System.Drawing.Size(50, 26);
            this.textBoxCustomerId.TabIndex = 17;
            // 
            // textBoxPassID
            // 
            this.textBoxPassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPassID.Location = new System.Drawing.Point(171, 31);
            this.textBoxPassID.Name = "textBoxPassID";
            this.textBoxPassID.ReadOnly = true;
            this.textBoxPassID.Size = new System.Drawing.Size(50, 26);
            this.textBoxPassID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата активации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер клиента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата диактивации:";
            // 
            // textBoxActivationDate
            // 
            this.textBoxActivationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxActivationDate.Location = new System.Drawing.Point(408, 31);
            this.textBoxActivationDate.Name = "textBoxActivationDate";
            this.textBoxActivationDate.ReadOnly = true;
            this.textBoxActivationDate.Size = new System.Drawing.Size(157, 26);
            this.textBoxActivationDate.TabIndex = 9;
            // 
            // comboBoxSlotId
            // 
            this.comboBoxSlotId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSlotId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSlotId.FormattingEnabled = true;
            this.comboBoxSlotId.ItemHeight = 20;
            this.comboBoxSlotId.Location = new System.Drawing.Point(195, 41);
            this.comboBoxSlotId.Name = "comboBoxSlotId";
            this.comboBoxSlotId.Size = new System.Drawing.Size(157, 28);
            this.comboBoxSlotId.TabIndex = 20;
            // 
            // textBoxNumOfExtends
            // 
            this.textBoxNumOfExtends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumOfExtends.Location = new System.Drawing.Point(680, 39);
            this.textBoxNumOfExtends.Name = "textBoxNumOfExtends";
            this.textBoxNumOfExtends.ReadOnly = true;
            this.textBoxNumOfExtends.Size = new System.Drawing.Size(50, 26);
            this.textBoxNumOfExtends.TabIndex = 19;
            // 
            // iconButtonUPDATESlot
            // 
            this.iconButtonUPDATESlot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonUPDATESlot.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonUPDATESlot.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonUPDATESlot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUPDATESlot.IconSize = 20;
            this.iconButtonUPDATESlot.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUPDATESlot.Location = new System.Drawing.Point(382, 39);
            this.iconButtonUPDATESlot.Name = "iconButtonUPDATESlot";
            this.iconButtonUPDATESlot.Size = new System.Drawing.Size(101, 32);
            this.iconButtonUPDATESlot.TabIndex = 12;
            this.iconButtonUPDATESlot.Text = "Применить";
            this.iconButtonUPDATESlot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUPDATESlot.UseVisualStyleBackColor = true;
            this.iconButtonUPDATESlot.Click += new System.EventHandler(this.iconButtonUPDATESlot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 38);
            this.label7.TabIndex = 18;
            this.label7.Text = "Количество\r\nпродлений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид аренды:";
            // 
            // iconButtonExtendRent
            // 
            this.iconButtonExtendRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExtendRent.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonExtendRent.IconColor = System.Drawing.Color.Olive;
            this.iconButtonExtendRent.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonExtendRent.IconSize = 35;
            this.iconButtonExtendRent.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButtonExtendRent.Location = new System.Drawing.Point(571, 81);
            this.iconButtonExtendRent.Name = "iconButtonExtendRent";
            this.iconButtonExtendRent.Size = new System.Drawing.Size(159, 54);
            this.iconButtonExtendRent.TabIndex = 7;
            this.iconButtonExtendRent.Text = "Продлить абонимент";
            this.iconButtonExtendRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExtendRent.UseVisualStyleBackColor = true;
            this.iconButtonExtendRent.Click += new System.EventHandler(this.iconButtonExtendRent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер места:";
            // 
            // iconButtonUPDATEPlan
            // 
            this.iconButtonUPDATEPlan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonUPDATEPlan.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonUPDATEPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUPDATEPlan.IconSize = 20;
            this.iconButtonUPDATEPlan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUPDATEPlan.Location = new System.Drawing.Point(382, 90);
            this.iconButtonUPDATEPlan.Name = "iconButtonUPDATEPlan";
            this.iconButtonUPDATEPlan.Size = new System.Drawing.Size(101, 32);
            this.iconButtonUPDATEPlan.TabIndex = 11;
            this.iconButtonUPDATEPlan.Text = "Применить";
            this.iconButtonUPDATEPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUPDATEPlan.UseVisualStyleBackColor = true;
            this.iconButtonUPDATEPlan.Click += new System.EventHandler(this.iconButtonUPDATEPlan_Click);
            // 
            // comboBoxTypeOfRent
            // 
            this.comboBoxTypeOfRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTypeOfRent.FormattingEnabled = true;
            this.comboBoxTypeOfRent.ItemHeight = 20;
            this.comboBoxTypeOfRent.Location = new System.Drawing.Point(195, 90);
            this.comboBoxTypeOfRent.Name = "comboBoxTypeOfRent";
            this.comboBoxTypeOfRent.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTypeOfRent.TabIndex = 13;
            // 
            // dataGridViewPasses
            // 
            this.dataGridViewPasses.AllowUserToAddRows = false;
            this.dataGridViewPasses.AllowUserToDeleteRows = false;
            this.dataGridViewPasses.AllowUserToResizeColumns = false;
            this.dataGridViewPasses.AllowUserToResizeRows = false;
            this.dataGridViewPasses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassesColumnPassId,
            this.PassesColumnCustomerId,
            this.PassesColumnSlotId,
            this.PassesColumnTypeOfRent,
            this.PassesColumnActivationDate,
            this.PassesColumnDiactivationDate,
            this.PassesColumnNumOfExtends});
            this.dataGridViewPasses.Location = new System.Drawing.Point(52, 73);
            this.dataGridViewPasses.Name = "dataGridViewPasses";
            this.dataGridViewPasses.ReadOnly = true;
            this.dataGridViewPasses.RowHeadersVisible = false;
            this.dataGridViewPasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPasses.Size = new System.Drawing.Size(769, 220);
            this.dataGridViewPasses.TabIndex = 2;
            this.dataGridViewPasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPasses_CellClick);
            this.dataGridViewPasses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPasses_CellFormatting);
            // 
            // PassesColumnPassId
            // 
            this.PassesColumnPassId.HeaderText = "Номер абонимента";
            this.PassesColumnPassId.Name = "PassesColumnPassId";
            this.PassesColumnPassId.ReadOnly = true;
            this.PassesColumnPassId.Width = 80;
            // 
            // PassesColumnCustomerId
            // 
            this.PassesColumnCustomerId.HeaderText = "Номер клиента";
            this.PassesColumnCustomerId.Name = "PassesColumnCustomerId";
            this.PassesColumnCustomerId.ReadOnly = true;
            this.PassesColumnCustomerId.Width = 110;
            // 
            // PassesColumnSlotId
            // 
            this.PassesColumnSlotId.HeaderText = "Номер места";
            this.PassesColumnSlotId.Name = "PassesColumnSlotId";
            this.PassesColumnSlotId.ReadOnly = true;
            // 
            // PassesColumnTypeOfRent
            // 
            this.PassesColumnTypeOfRent.HeaderText = "Вид аренды";
            this.PassesColumnTypeOfRent.Name = "PassesColumnTypeOfRent";
            this.PassesColumnTypeOfRent.ReadOnly = true;
            // 
            // PassesColumnActivationDate
            // 
            this.PassesColumnActivationDate.HeaderText = "Дата активации";
            this.PassesColumnActivationDate.Name = "PassesColumnActivationDate";
            this.PassesColumnActivationDate.ReadOnly = true;
            this.PassesColumnActivationDate.Width = 120;
            // 
            // PassesColumnDiactivationDate
            // 
            this.PassesColumnDiactivationDate.HeaderText = "Дата диактивации";
            this.PassesColumnDiactivationDate.Name = "PassesColumnDiactivationDate";
            this.PassesColumnDiactivationDate.ReadOnly = true;
            this.PassesColumnDiactivationDate.Width = 130;
            // 
            // PassesColumnNumOfExtends
            // 
            this.PassesColumnNumOfExtends.HeaderText = "Количество продлений";
            this.PassesColumnNumOfExtends.Name = "PassesColumnNumOfExtends";
            this.PassesColumnNumOfExtends.ReadOnly = true;
            this.PassesColumnNumOfExtends.Width = 89;
            // 
            // FormPasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 632);
            this.Controls.Add(this.dataGridViewPasses);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.panel1);
            this.Name = "FormPasses";
            this.Text = "FormPasses";
            this.Load += new System.EventHandler(this.FormPasses_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPasses;
        private System.Windows.Forms.TextBox textBoxDiactivationDate;
        private System.Windows.Forms.TextBox textBoxActivationDate;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButtonExtendRent;
        private FontAwesome.Sharp.IconButton iconButtonUPDATEPlan;
        private FontAwesome.Sharp.IconButton iconButtonUPDATESlot;
        private System.Windows.Forms.ComboBox comboBoxTypeOfRent;
        private System.Windows.Forms.TextBox textBoxNumOfExtends;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnPassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnSlotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnTypeOfRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnActivationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnDiactivationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassesColumnNumOfExtends;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxSlotId;
        private FontAwesome.Sharp.IconButton iconButtonSortBy;
        private FontAwesome.Sharp.IconButton iconButtonFilterBy;
    }
}