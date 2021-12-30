
namespace Parking.Forms.Slots
{
    partial class FormSlots
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
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSlotID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFloorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.checkBoxIsBusy = new System.Windows.Forms.CheckBox();
            this.SlotsColumnSlotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotsColumnFloorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlotsColumnIsBusy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.AllowUserToAddRows = false;
            this.dataGridViewSlots.AllowUserToDeleteRows = false;
            this.dataGridViewSlots.AllowUserToResizeColumns = false;
            this.dataGridViewSlots.AllowUserToResizeRows = false;
            this.dataGridViewSlots.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSlots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlotsColumnSlotId,
            this.SlotsColumnFloorId,
            this.SlotsColumnIsBusy});
            this.dataGridViewSlots.Location = new System.Drawing.Point(74, 96);
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.ReadOnly = true;
            this.dataGridViewSlots.RowHeadersVisible = false;
            this.dataGridViewSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlots.Size = new System.Drawing.Size(345, 513);
            this.dataGridViewSlots.TabIndex = 0;
            this.dataGridViewSlots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSlots_CellClick);
            this.dataGridViewSlots.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSlots_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.checkBoxIsBusy);
            this.panel2.Controls.Add(this.textBoxSlotID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxFloorID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(458, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 600);
            this.panel2.TabIndex = 9;
            // 
            // textBoxSlotID
            // 
            this.textBoxSlotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSlotID.Location = new System.Drawing.Point(180, 182);
            this.textBoxSlotID.Name = "textBoxSlotID";
            this.textBoxSlotID.ReadOnly = true;
            this.textBoxSlotID.Size = new System.Drawing.Size(157, 26);
            this.textBoxSlotID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер места:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Занято:";
            // 
            // textBoxFloorID
            // 
            this.textBoxFloorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFloorID.Location = new System.Drawing.Point(180, 227);
            this.textBoxFloorID.Name = "textBoxFloorID";
            this.textBoxFloorID.ReadOnly = true;
            this.textBoxFloorID.Size = new System.Drawing.Size(157, 26);
            this.textBoxFloorID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер этажа:";
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(74, 43);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 10;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            this.iconButtonUpdateTable.Click += new System.EventHandler(this.iconButtonUpdateTable_Click);
            // 
            // checkBoxIsBusy
            // 
            this.checkBoxIsBusy.AutoSize = true;
            this.checkBoxIsBusy.Location = new System.Drawing.Point(248, 280);
            this.checkBoxIsBusy.Name = "checkBoxIsBusy";
            this.checkBoxIsBusy.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsBusy.TabIndex = 11;
            this.checkBoxIsBusy.UseVisualStyleBackColor = true;
            // 
            // SlotsColumnSlotId
            // 
            this.SlotsColumnSlotId.HeaderText = "Номер места";
            this.SlotsColumnSlotId.Name = "SlotsColumnSlotId";
            this.SlotsColumnSlotId.ReadOnly = true;
            this.SlotsColumnSlotId.Width = 110;
            // 
            // SlotsColumnFloorId
            // 
            this.SlotsColumnFloorId.HeaderText = "Номер этажа";
            this.SlotsColumnFloorId.Name = "SlotsColumnFloorId";
            this.SlotsColumnFloorId.ReadOnly = true;
            this.SlotsColumnFloorId.Width = 110;
            // 
            // SlotsColumnIsBusy
            // 
            this.SlotsColumnIsBusy.HeaderText = "Занято";
            this.SlotsColumnIsBusy.Name = "SlotsColumnIsBusy";
            this.SlotsColumnIsBusy.ReadOnly = true;
            this.SlotsColumnIsBusy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlotsColumnIsBusy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SlotsColumnIsBusy.Width = 110;
            // 
            // FormSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 600);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.dataGridViewSlots);
            this.Controls.Add(this.panel2);
            this.Name = "FormSlots";
            this.Text = "FormSlots";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSlotID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFloorID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnSlotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlotsColumnFloorId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SlotsColumnIsBusy;
        private System.Windows.Forms.CheckBox checkBoxIsBusy;
    }
}