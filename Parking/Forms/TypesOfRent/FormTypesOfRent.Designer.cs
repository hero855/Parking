
namespace Parking.Forms.TypesOfRent
{
    partial class FormTypesOfRent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnitsOfMeasure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTypeOfRent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTypesOfRent = new System.Windows.Forms.DataGridView();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesOfRent)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxUnitsOfMeasure);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxTypeOfRent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(434, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 450);
            this.panel1.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPrice.Location = new System.Drawing.Point(159, 273);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(157, 26);
            this.textBoxPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стоимость:";
            // 
            // textBoxUnitsOfMeasure
            // 
            this.textBoxUnitsOfMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxUnitsOfMeasure.Location = new System.Drawing.Point(159, 321);
            this.textBoxUnitsOfMeasure.Name = "textBoxUnitsOfMeasure";
            this.textBoxUnitsOfMeasure.ReadOnly = true;
            this.textBoxUnitsOfMeasure.Size = new System.Drawing.Size(157, 26);
            this.textBoxUnitsOfMeasure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Единицы\r\nизмерения:";
            // 
            // textBoxTypeOfRent
            // 
            this.textBoxTypeOfRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTypeOfRent.Location = new System.Drawing.Point(159, 226);
            this.textBoxTypeOfRent.Name = "textBoxTypeOfRent";
            this.textBoxTypeOfRent.ReadOnly = true;
            this.textBoxTypeOfRent.Size = new System.Drawing.Size(157, 26);
            this.textBoxTypeOfRent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид аренды:";
            // 
            // dataGridViewTypesOfRent
            // 
            this.dataGridViewTypesOfRent.AllowUserToAddRows = false;
            this.dataGridViewTypesOfRent.AllowUserToDeleteRows = false;
            this.dataGridViewTypesOfRent.AllowUserToResizeColumns = false;
            this.dataGridViewTypesOfRent.AllowUserToResizeRows = false;
            this.dataGridViewTypesOfRent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTypesOfRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTypesOfRent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTypesOfRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypesOfRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridViewTypesOfRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTypesOfRent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTypesOfRent.Name = "dataGridViewTypesOfRent";
            this.dataGridViewTypesOfRent.ReadOnly = true;
            this.dataGridViewTypesOfRent.RowHeadersVisible = false;
            this.dataGridViewTypesOfRent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTypesOfRent.Size = new System.Drawing.Size(328, 220);
            this.dataGridViewTypesOfRent.TabIndex = 2;
            this.dataGridViewTypesOfRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTypesOfRent_CellClick);
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(61, 137);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 7;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTypesOfRent);
            this.panel2.Location = new System.Drawing.Point(62, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 220);
            this.panel2.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Вид аренды";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Единицы измерения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FormTypesOfRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.panel2);
            this.Name = "FormTypesOfRent";
            this.Text = "FormTypesOfRent";
            this.Load += new System.EventHandler(this.FormTypesOfRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypesOfRent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTypeOfRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTypesOfRent;
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnitsOfMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}