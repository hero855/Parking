
namespace Parking.Forms.Passes
{
    partial class FormPassesFilterBy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonFilterBy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Поле";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Оператор";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Значение";
            this.Column3.Name = "Column3";
            // 
            // iconButtonFilterBy
            // 
            this.iconButtonFilterBy.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButtonFilterBy.IconColor = System.Drawing.Color.Black;
            this.iconButtonFilterBy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFilterBy.IconSize = 20;
            this.iconButtonFilterBy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonFilterBy.Location = new System.Drawing.Point(306, 186);
            this.iconButtonFilterBy.Name = "iconButtonFilterBy";
            this.iconButtonFilterBy.Size = new System.Drawing.Size(116, 35);
            this.iconButtonFilterBy.TabIndex = 22;
            this.iconButtonFilterBy.Text = "Фильтровать";
            this.iconButtonFilterBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFilterBy.UseVisualStyleBackColor = true;
            this.iconButtonFilterBy.Click += new System.EventHandler(this.iconButtonFilterBy_Click);
            // 
            // FormPassesFilterBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 233);
            this.Controls.Add(this.iconButtonFilterBy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPassesFilterBy";
            this.Text = "FormPassesFilterBy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton iconButtonFilterBy;
    }
}