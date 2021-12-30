
namespace Parking.Forms.Passes
{
    partial class FormPassesSortBy
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
            this.comboBoxColumnName = new System.Windows.Forms.ComboBox();
            this.iconButtonSortby = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxColumnName
            // 
            this.comboBoxColumnName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxColumnName.FormattingEnabled = true;
            this.comboBoxColumnName.ItemHeight = 20;
            this.comboBoxColumnName.Location = new System.Drawing.Point(193, 25);
            this.comboBoxColumnName.Name = "comboBoxColumnName";
            this.comboBoxColumnName.Size = new System.Drawing.Size(157, 28);
            this.comboBoxColumnName.TabIndex = 23;
            // 
            // iconButtonSortby
            // 
            this.iconButtonSortby.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonSortby.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonSortby.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonSortby.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSortby.IconSize = 20;
            this.iconButtonSortby.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonSortby.Location = new System.Drawing.Point(128, 118);
            this.iconButtonSortby.Name = "iconButtonSortby";
            this.iconButtonSortby.Size = new System.Drawing.Size(101, 32);
            this.iconButtonSortby.TabIndex = 21;
            this.iconButtonSortby.Text = "Принять";
            this.iconButtonSortby.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSortby.UseVisualStyleBackColor = true;
            this.iconButtonSortby.Click += new System.EventHandler(this.iconButtonSortby_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Сортировать по:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.ItemHeight = 20;
            this.comboBoxOrder.Location = new System.Drawing.Point(193, 59);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(157, 28);
            this.comboBoxOrder.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Порядок:";
            // 
            // FormPassesSortBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 171);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxColumnName);
            this.Controls.Add(this.iconButtonSortby);
            this.Controls.Add(this.label6);
            this.Name = "FormPassesSortBy";
            this.Text = "FormPassesSortBy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxColumnName;
        private FontAwesome.Sharp.IconButton iconButtonSortby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Label label1;
    }
}