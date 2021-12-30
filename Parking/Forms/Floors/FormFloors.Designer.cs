
namespace Parking.Forms
{
    partial class FormFloors
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
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewFloors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFloorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumOfSlots = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonUPDATE = new FontAwesome.Sharp.IconButton();
            this.comboBoxTypesOfRent = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FloorsColumnFloorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorsColumnNumOfSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorsColumnTyreOfRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(84, 150);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 1;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            this.iconButtonUpdateTable.Click += new System.EventHandler(this.iconButtonUpdateTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFloors);
            this.panel2.Location = new System.Drawing.Point(84, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 220);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewFloors
            // 
            this.dataGridViewFloors.AllowUserToAddRows = false;
            this.dataGridViewFloors.AllowUserToDeleteRows = false;
            this.dataGridViewFloors.AllowUserToResizeColumns = false;
            this.dataGridViewFloors.AllowUserToResizeRows = false;
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
            this.FloorsColumnTyreOfRent});
            this.dataGridViewFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFloors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFloors.Name = "dataGridViewFloors";
            this.dataGridViewFloors.ReadOnly = true;
            this.dataGridViewFloors.RowHeadersVisible = false;
            this.dataGridViewFloors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFloors.Size = new System.Drawing.Size(311, 220);
            this.dataGridViewFloors.TabIndex = 2;
            this.dataGridViewFloors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridViewFloors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер этажа:";
            // 
            // textBoxFloorID
            // 
            this.textBoxFloorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFloorID.Location = new System.Drawing.Point(184, 184);
            this.textBoxFloorID.Name = "textBoxFloorID";
            this.textBoxFloorID.ReadOnly = true;
            this.textBoxFloorID.Size = new System.Drawing.Size(157, 26);
            this.textBoxFloorID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество мест:";
            // 
            // textBoxNumOfSlots
            // 
            this.textBoxNumOfSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumOfSlots.Location = new System.Drawing.Point(184, 231);
            this.textBoxNumOfSlots.Name = "textBoxNumOfSlots";
            this.textBoxNumOfSlots.ReadOnly = true;
            this.textBoxNumOfSlots.Size = new System.Drawing.Size(157, 26);
            this.textBoxNumOfSlots.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид аренды: ";
            // 
            // iconButtonUPDATE
            // 
            this.iconButtonUPDATE.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonUPDATE.IconColor = System.Drawing.Color.Black;
            this.iconButtonUPDATE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUPDATE.IconSize = 20;
            this.iconButtonUPDATE.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUPDATE.Location = new System.Drawing.Point(70, 348);
            this.iconButtonUPDATE.Name = "iconButtonUPDATE";
            this.iconButtonUPDATE.Size = new System.Drawing.Size(239, 32);
            this.iconButtonUPDATE.TabIndex = 7;
            this.iconButtonUPDATE.Text = "Изменить требуемый план абонимента";
            this.iconButtonUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUPDATE.UseVisualStyleBackColor = true;
            this.iconButtonUPDATE.Click += new System.EventHandler(this.iconButtonUPDATE_Click);
            // 
            // comboBoxTypesOfRent
            // 
            this.comboBoxTypesOfRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypesOfRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTypesOfRent.FormattingEnabled = true;
            this.comboBoxTypesOfRent.ItemHeight = 20;
            this.comboBoxTypesOfRent.Location = new System.Drawing.Point(184, 277);
            this.comboBoxTypesOfRent.Name = "comboBoxTypesOfRent";
            this.comboBoxTypesOfRent.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTypesOfRent.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comboBoxTypesOfRent);
            this.panel1.Controls.Add(this.iconButtonUPDATE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNumOfSlots);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxFloorID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(434, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 538);
            this.panel1.TabIndex = 3;
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
            // FloorsColumnTyreOfRent
            // 
            this.FloorsColumnTyreOfRent.HeaderText = "Вид аренды";
            this.FloorsColumnTyreOfRent.Name = "FloorsColumnTyreOfRent";
            this.FloorsColumnTyreOfRent.ReadOnly = true;
            this.FloorsColumnTyreOfRent.Width = 120;
            // 
            // FormFloors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormFloors";
            this.Text = "FormFloors";
            this.Load += new System.EventHandler(this.FormFloors_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFloorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumOfSlots;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonUPDATE;
        private System.Windows.Forms.ComboBox comboBoxTypesOfRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewFloors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnFloorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnNumOfSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorsColumnTyreOfRent;
    }
}