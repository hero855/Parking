
namespace Parking.Forms.Customers
{
    partial class FormNewCustomer
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
            this.iconButtonCreate = new FontAwesome.Sharp.IconButton();
            this.comboBoxSlotId = new System.Windows.Forms.ComboBox();
            this.textBoxNumOfExtends = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfRent = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxRegularCustomer = new System.Windows.Forms.CheckBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAutoType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonCreate
            // 
            this.iconButtonCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButtonCreate.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonCreate.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreate.IconSize = 20;
            this.iconButtonCreate.Location = new System.Drawing.Point(383, 0);
            this.iconButtonCreate.Name = "iconButtonCreate";
            this.iconButtonCreate.Size = new System.Drawing.Size(90, 299);
            this.iconButtonCreate.TabIndex = 19;
            this.iconButtonCreate.Text = "Добавить";
            this.iconButtonCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreate.UseVisualStyleBackColor = true;
            this.iconButtonCreate.Click += new System.EventHandler(this.iconButtonCreate_Click);
            // 
            // comboBoxSlotId
            // 
            this.comboBoxSlotId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSlotId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxSlotId.FormattingEnabled = true;
            this.comboBoxSlotId.ItemHeight = 20;
            this.comboBoxSlotId.Location = new System.Drawing.Point(182, 13);
            this.comboBoxSlotId.Name = "comboBoxSlotId";
            this.comboBoxSlotId.Size = new System.Drawing.Size(157, 28);
            this.comboBoxSlotId.TabIndex = 29;
            this.comboBoxSlotId.SelectedIndexChanged += new System.EventHandler(this.comboBoxSlotId_SelectedIndexChanged);
            // 
            // textBoxNumOfExtends
            // 
            this.textBoxNumOfExtends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxNumOfExtends.Location = new System.Drawing.Point(182, 82);
            this.textBoxNumOfExtends.Name = "textBoxNumOfExtends";
            this.textBoxNumOfExtends.Size = new System.Drawing.Size(50, 26);
            this.textBoxNumOfExtends.TabIndex = 28;
            this.textBoxNumOfExtends.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 38);
            this.label7.TabIndex = 27;
            this.label7.Text = "Количество\r\nпродлений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Вид аренды:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Номер места:";
            // 
            // comboBoxTypeOfRent
            // 
            this.comboBoxTypeOfRent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxTypeOfRent.FormattingEnabled = true;
            this.comboBoxTypeOfRent.ItemHeight = 20;
            this.comboBoxTypeOfRent.Location = new System.Drawing.Point(182, 47);
            this.comboBoxTypeOfRent.Name = "comboBoxTypeOfRent";
            this.comboBoxTypeOfRent.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTypeOfRent.TabIndex = 25;
            this.comboBoxTypeOfRent.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOfRent_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.maskedTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxRegularCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCustomerID);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxAutoType);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSlotId);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNumOfExtends);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTypeOfRent);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(379, 299);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 30;
            // 
            // checkBoxRegularCustomer
            // 
            this.checkBoxRegularCustomer.AutoSize = true;
            this.checkBoxRegularCustomer.Enabled = false;
            this.checkBoxRegularCustomer.Location = new System.Drawing.Point(251, 94);
            this.checkBoxRegularCustomer.Name = "checkBoxRegularCustomer";
            this.checkBoxRegularCustomer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRegularCustomer.TabIndex = 18;
            this.checkBoxRegularCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(182, 14);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(157, 26);
            this.textBoxCustomerID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Номер клиента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Контактный номер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Это постоянный\r\nклиент";
            // 
            // textBoxAutoType
            // 
            this.textBoxAutoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxAutoType.Location = new System.Drawing.Point(182, 46);
            this.textBoxAutoType.Name = "textBoxAutoType";
            this.textBoxAutoType.Size = new System.Drawing.Size(157, 26);
            this.textBoxAutoType.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.4F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Тип машины:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maskedTextBox1.Location = new System.Drawing.Point(182, 127);
            this.maskedTextBox1.Mask = "+7 (999) 000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(157, 26);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.iconButtonCreate);
            this.Name = "FormNewCustomer";
            this.Text = "FormNewCustomer";
            this.Load += new System.EventHandler(this.FormNewCustomer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonCreate;
        private System.Windows.Forms.ComboBox comboBoxSlotId;
        private System.Windows.Forms.TextBox textBoxNumOfExtends;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTypeOfRent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxRegularCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAutoType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}