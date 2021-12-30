
namespace Parking.Forms.Other
{
    partial class FormOther
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
            this.dataGridViewUnitsOfMeasure = new System.Windows.Forms.DataGridView();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxUnitOfMeasure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitsOfMeasure)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUnitsOfMeasure
            // 
            this.dataGridViewUnitsOfMeasure.AllowUserToAddRows = false;
            this.dataGridViewUnitsOfMeasure.AllowUserToDeleteRows = false;
            this.dataGridViewUnitsOfMeasure.AllowUserToResizeColumns = false;
            this.dataGridViewUnitsOfMeasure.AllowUserToResizeRows = false;
            this.dataGridViewUnitsOfMeasure.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUnitsOfMeasure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnitsOfMeasure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUnitsOfMeasure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnitsOfMeasure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewUnitsOfMeasure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnitsOfMeasure.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUnitsOfMeasure.Name = "dataGridViewUnitsOfMeasure";
            this.dataGridViewUnitsOfMeasure.ReadOnly = true;
            this.dataGridViewUnitsOfMeasure.RowHeadersVisible = false;
            this.dataGridViewUnitsOfMeasure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnitsOfMeasure.Size = new System.Drawing.Size(168, 220);
            this.dataGridViewUnitsOfMeasure.TabIndex = 2;
            this.dataGridViewUnitsOfMeasure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnitsOfMeasure_CellClick);
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(150, 136);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 4;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            this.iconButtonUpdateTable.Click += new System.EventHandler(this.iconButtonUpdateTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewUnitsOfMeasure);
            this.panel2.Location = new System.Drawing.Point(150, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 220);
            this.panel2.TabIndex = 5;
            // 
            // textBoxUnitOfMeasure
            // 
            this.textBoxUnitOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxUnitOfMeasure.Location = new System.Drawing.Point(184, 226);
            this.textBoxUnitOfMeasure.Name = "textBoxUnitOfMeasure";
            this.textBoxUnitOfMeasure.ReadOnly = true;
            this.textBoxUnitOfMeasure.Size = new System.Drawing.Size(157, 26);
            this.textBoxUnitOfMeasure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Единица измерения";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxUnitOfMeasure);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(434, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 450);
            this.panel1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Единица измерения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // FormOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOther";
            this.Text = "FormOther";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnitsOfMeasure)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUnitsOfMeasure;
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxUnitOfMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}