
namespace Parking.Forms.Floors
{
    partial class FormFloorsDELETE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconButtonDELETE = new FontAwesome.Sharp.IconButton();
            this.textBoxFloorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewFloors = new System.Windows.Forms.DataGridView();
            this.labelFloorsTableTitle = new System.Windows.Forms.Label();
            this.iconButtonUpdateTable = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonDELETE
            // 
            this.iconButtonDELETE.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonDELETE.IconColor = System.Drawing.Color.DarkRed;
            this.iconButtonDELETE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDELETE.IconSize = 20;
            this.iconButtonDELETE.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDELETE.Location = new System.Drawing.Point(469, 31);
            this.iconButtonDELETE.Name = "iconButtonDELETE";
            this.iconButtonDELETE.Size = new System.Drawing.Size(88, 31);
            this.iconButtonDELETE.TabIndex = 8;
            this.iconButtonDELETE.Text = "Удалить";
            this.iconButtonDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDELETE.UseVisualStyleBackColor = true;
            // 
            // textBoxFloorID
            // 
            this.textBoxFloorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFloorID.Location = new System.Drawing.Point(269, 32);
            this.textBoxFloorID.Name = "textBoxFloorID";
            this.textBoxFloorID.ReadOnly = true;
            this.textBoxFloorID.Size = new System.Drawing.Size(157, 26);
            this.textBoxFloorID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(138, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер этажа:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewFloors);
            this.panel2.Controls.Add(this.labelFloorsTableTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 233);
            this.panel2.TabIndex = 5;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFloors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFloors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFloors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFloors.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewFloors.Name = "dataGridViewFloors";
            this.dataGridViewFloors.RowHeadersVisible = false;
            this.dataGridViewFloors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFloors.Size = new System.Drawing.Size(339, 203);
            this.dataGridViewFloors.TabIndex = 1;
            // 
            // labelFloorsTableTitle
            // 
            this.labelFloorsTableTitle.BackColor = System.Drawing.Color.Silver;
            this.labelFloorsTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFloorsTableTitle.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloorsTableTitle.ForeColor = System.Drawing.Color.Black;
            this.labelFloorsTableTitle.Location = new System.Drawing.Point(0, 0);
            this.labelFloorsTableTitle.Name = "labelFloorsTableTitle";
            this.labelFloorsTableTitle.Size = new System.Drawing.Size(339, 30);
            this.labelFloorsTableTitle.TabIndex = 0;
            this.labelFloorsTableTitle.Text = "Этажи";
            // 
            // iconButtonUpdateTable
            // 
            this.iconButtonUpdateTable.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButtonUpdateTable.IconColor = System.Drawing.Color.Olive;
            this.iconButtonUpdateTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateTable.IconSize = 20;
            this.iconButtonUpdateTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(20, 73);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 4;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewSlots);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 233);
            this.panel1.TabIndex = 6;
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.AllowUserToAddRows = false;
            this.dataGridViewSlots.AllowUserToDeleteRows = false;
            this.dataGridViewSlots.AllowUserToResizeColumns = false;
            this.dataGridViewSlots.AllowUserToResizeRows = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSlots.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSlots.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSlots.Location = new System.Drawing.Point(0, 56);
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.RowHeadersVisible = false;
            this.dataGridViewSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSlots.Size = new System.Drawing.Size(329, 177);
            this.dataGridViewSlots.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Подченённая табл:\r\nПарковочные места";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(21, 126);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(672, 233);
            this.splitContainer2.SplitterDistance = 339;
            this.splitContainer2.TabIndex = 0;
            // 
            // FormFloorsDELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 389);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.textBoxFloorID);
            this.Controls.Add(this.iconButtonDELETE);
            this.Controls.Add(this.label1);
            this.Name = "FormFloorsDELETE";
            this.Text = "FormFloorsDELETE";
            this.Load += new System.EventHandler(this.FormFloorsDELETE_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFloors)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonDELETE;
        private System.Windows.Forms.TextBox textBoxFloorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewFloors;
        private System.Windows.Forms.Label labelFloorsTableTitle;
        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}