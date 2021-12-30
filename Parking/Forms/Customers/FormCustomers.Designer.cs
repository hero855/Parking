
namespace Parking.Forms.Customers
{
    partial class FormCustomers
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonCreateCustomer = new FontAwesome.Sharp.IconButton();
            this.iconButtonUPDATEAutoType = new FontAwesome.Sharp.IconButton();
            this.checkBoxRegularCustomer = new System.Windows.Forms.CheckBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButtonUPDATEPhoneNumber = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
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
            this.iconButtonUpdateTable.Location = new System.Drawing.Point(223, 36);
            this.iconButtonUpdateTable.Name = "iconButtonUpdateTable";
            this.iconButtonUpdateTable.Size = new System.Drawing.Size(88, 32);
            this.iconButtonUpdateTable.TabIndex = 4;
            this.iconButtonUpdateTable.Text = "Обновить";
            this.iconButtonUpdateTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateTable.UseVisualStyleBackColor = false;
            this.iconButtonUpdateTable.Click += new System.EventHandler(this.iconButtonUpdateTable_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeColumns = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(223, 74);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(489, 295);
            this.dataGridViewCustomers.TabIndex = 2;
            this.dataGridViewCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellClick);
            this.dataGridViewCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCustomers_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер клиента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип машины";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Это постоянный клиент";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Контактный номер";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.iconButtonCreateCustomer);
            this.panel1.Controls.Add(this.iconButtonUPDATEAutoType);
            this.panel1.Controls.Add(this.checkBoxRegularCustomer);
            this.panel1.Controls.Add(this.textBoxCustomerID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconButtonUPDATEPhoneNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxAutoType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 213);
            this.panel1.TabIndex = 6;
            // 
            // iconButtonCreateCustomer
            // 
            this.iconButtonCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateCustomer.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButtonCreateCustomer.IconColor = System.Drawing.Color.Olive;
            this.iconButtonCreateCustomer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonCreateCustomer.IconSize = 35;
            this.iconButtonCreateCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.iconButtonCreateCustomer.Location = new System.Drawing.Point(667, 78);
            this.iconButtonCreateCustomer.Name = "iconButtonCreateCustomer";
            this.iconButtonCreateCustomer.Size = new System.Drawing.Size(197, 54);
            this.iconButtonCreateCustomer.TabIndex = 12;
            this.iconButtonCreateCustomer.Text = "Добавить нового клиента";
            this.iconButtonCreateCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreateCustomer.UseVisualStyleBackColor = true;
            this.iconButtonCreateCustomer.Click += new System.EventHandler(this.iconButtonCreateCustomer_Click);
            // 
            // iconButtonUPDATEAutoType
            // 
            this.iconButtonUPDATEAutoType.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonUPDATEAutoType.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonUPDATEAutoType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUPDATEAutoType.IconSize = 20;
            this.iconButtonUPDATEAutoType.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUPDATEAutoType.Location = new System.Drawing.Point(453, 68);
            this.iconButtonUPDATEAutoType.Name = "iconButtonUPDATEAutoType";
            this.iconButtonUPDATEAutoType.Size = new System.Drawing.Size(95, 32);
            this.iconButtonUPDATEAutoType.TabIndex = 11;
            this.iconButtonUPDATEAutoType.Text = "Изменить";
            this.iconButtonUPDATEAutoType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUPDATEAutoType.UseVisualStyleBackColor = true;
            this.iconButtonUPDATEAutoType.Click += new System.EventHandler(this.iconButtonUPDATEAutoType_Click);
            // 
            // checkBoxRegularCustomer
            // 
            this.checkBoxRegularCustomer.AutoSize = true;
            this.checkBoxRegularCustomer.Enabled = false;
            this.checkBoxRegularCustomer.Location = new System.Drawing.Point(315, 118);
            this.checkBoxRegularCustomer.Name = "checkBoxRegularCustomer";
            this.checkBoxRegularCustomer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRegularCustomer.TabIndex = 10;
            this.checkBoxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(246, 38);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(157, 26);
            this.textBoxCustomerID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(81, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер клиента:";
            // 
            // iconButtonUPDATEPhoneNumber
            // 
            this.iconButtonUPDATEPhoneNumber.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonUPDATEPhoneNumber.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonUPDATEPhoneNumber.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUPDATEPhoneNumber.IconSize = 20;
            this.iconButtonUPDATEPhoneNumber.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUPDATEPhoneNumber.Location = new System.Drawing.Point(453, 149);
            this.iconButtonUPDATEPhoneNumber.Name = "iconButtonUPDATEPhoneNumber";
            this.iconButtonUPDATEPhoneNumber.Size = new System.Drawing.Size(95, 32);
            this.iconButtonUPDATEPhoneNumber.TabIndex = 7;
            this.iconButtonUPDATEPhoneNumber.Text = "Изменить";
            this.iconButtonUPDATEPhoneNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUPDATEPhoneNumber.UseVisualStyleBackColor = true;
            this.iconButtonUPDATEPhoneNumber.Click += new System.EventHandler(this.iconButtonUPDATEPhoneNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Контактный номер:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(246, 151);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(157, 26);
            this.textBoxPhoneNumber.TabIndex = 3;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Это постоянный\r\nклиент";
            // 
            // textBoxAutoType
            // 
            this.textBoxAutoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAutoType.Location = new System.Drawing.Point(246, 70);
            this.textBoxAutoType.Name = "textBoxAutoType";
            this.textBoxAutoType.Size = new System.Drawing.Size(157, 26);
            this.textBoxAutoType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип машины:";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 590);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.iconButtonUpdateTable);
            this.Controls.Add(this.panel1);
            this.Name = "FormCustomers";
            this.Text = "FormCustomers";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonUpdateTable;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonUPDATEPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxRegularCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton iconButtonUPDATEAutoType;
        private FontAwesome.Sharp.IconButton iconButtonCreateCustomer;
    }
}