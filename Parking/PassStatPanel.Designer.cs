
namespace Parking
{
    partial class PassStatPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBody = new System.Windows.Forms.Panel();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelNumHint = new System.Windows.Forms.Label();
            this.splitContainerMiddle = new System.Windows.Forms.SplitContainer();
            this.labelIncome = new System.Windows.Forms.Label();
            this.labelIncomeHint = new System.Windows.Forms.Label();
            this.labelShare = new System.Windows.Forms.Label();
            this.labelShareHint = new System.Windows.Forms.Label();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.labelHint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxArrowUp = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxArrowDown = new FontAwesome.Sharp.IconPictureBox();
            this.labelDiff = new System.Windows.Forms.Label();
            this.gradientPanelHeader = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMiddle)).BeginInit();
            this.splitContainerMiddle.Panel1.SuspendLayout();
            this.splitContainerMiddle.Panel2.SuspendLayout();
            this.splitContainerMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxArrowUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxArrowDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelBody.Controls.Add(this.splitContainerTop);
            this.panelBody.Controls.Add(this.splitContainerBottom);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(0, 54);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(250, 226);
            this.panelBody.TabIndex = 4;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.IsSplitterFixed = true;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            this.splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.labelNum);
            this.splitContainerTop.Panel1.Controls.Add(this.labelNumHint);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.splitContainerMiddle);
            this.splitContainerTop.Size = new System.Drawing.Size(250, 192);
            this.splitContainerTop.SplitterDistance = 60;
            this.splitContainerTop.TabIndex = 17;
            // 
            // labelNum
            // 
            this.labelNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNum.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold);
            this.labelNum.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNum.Location = new System.Drawing.Point(0, 39);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(250, 20);
            this.labelNum.TabIndex = 5;
            this.labelNum.Text = "Num";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumHint
            // 
            this.labelNumHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNumHint.Font = new System.Drawing.Font("Candara Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumHint.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNumHint.Location = new System.Drawing.Point(0, 0);
            this.labelNumHint.Name = "labelNumHint";
            this.labelNumHint.Size = new System.Drawing.Size(250, 39);
            this.labelNumHint.TabIndex = 12;
            this.labelNumHint.Text = "Всего:";
            this.labelNumHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerMiddle
            // 
            this.splitContainerMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMiddle.IsSplitterFixed = true;
            this.splitContainerMiddle.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMiddle.Name = "splitContainerMiddle";
            this.splitContainerMiddle.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMiddle.Panel1
            // 
            this.splitContainerMiddle.Panel1.Controls.Add(this.labelIncome);
            this.splitContainerMiddle.Panel1.Controls.Add(this.labelIncomeHint);
            // 
            // splitContainerMiddle.Panel2
            // 
            this.splitContainerMiddle.Panel2.Controls.Add(this.labelShare);
            this.splitContainerMiddle.Panel2.Controls.Add(this.labelShareHint);
            this.splitContainerMiddle.Size = new System.Drawing.Size(250, 128);
            this.splitContainerMiddle.SplitterDistance = 54;
            this.splitContainerMiddle.TabIndex = 0;
            // 
            // labelIncome
            // 
            this.labelIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIncome.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold);
            this.labelIncome.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelIncome.Location = new System.Drawing.Point(0, 31);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(250, 20);
            this.labelIncome.TabIndex = 13;
            this.labelIncome.Text = "Income";
            this.labelIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIncomeHint
            // 
            this.labelIncomeHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIncomeHint.Font = new System.Drawing.Font("Candara Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncomeHint.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelIncomeHint.Location = new System.Drawing.Point(0, 0);
            this.labelIncomeHint.Name = "labelIncomeHint";
            this.labelIncomeHint.Size = new System.Drawing.Size(250, 31);
            this.labelIncomeHint.TabIndex = 14;
            this.labelIncomeHint.Text = "Доход:";
            this.labelIncomeHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelShare
            // 
            this.labelShare.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelShare.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold);
            this.labelShare.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelShare.Location = new System.Drawing.Point(0, 31);
            this.labelShare.Name = "labelShare";
            this.labelShare.Size = new System.Drawing.Size(250, 20);
            this.labelShare.TabIndex = 15;
            this.labelShare.Text = "Share";
            this.labelShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShareHint
            // 
            this.labelShareHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelShareHint.Font = new System.Drawing.Font("Candara Light", 15F);
            this.labelShareHint.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelShareHint.Location = new System.Drawing.Point(0, 0);
            this.labelShareHint.Name = "labelShareHint";
            this.labelShareHint.Size = new System.Drawing.Size(250, 31);
            this.labelShareHint.TabIndex = 17;
            this.labelShareHint.Text = "Доля: ";
            this.labelShareHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerBottom.IsSplitterFixed = true;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 192);
            this.splitContainerBottom.Name = "splitContainerBottom";
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.labelHint);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.panel1);
            this.splitContainerBottom.Size = new System.Drawing.Size(250, 34);
            this.splitContainerBottom.SplitterDistance = 160;
            this.splitContainerBottom.TabIndex = 0;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.labelHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHint.Font = new System.Drawing.Font("Candara Light", 7F, System.Drawing.FontStyle.Bold);
            this.labelHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelHint.Location = new System.Drawing.Point(0, 0);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(160, 34);
            this.labelHint.TabIndex = 6;
            this.labelHint.Text = "С прошлого месяца:";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconPictureBoxArrowUp);
            this.panel1.Controls.Add(this.iconPictureBoxArrowDown);
            this.panel1.Controls.Add(this.labelDiff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 34);
            this.panel1.TabIndex = 9;
            // 
            // iconPictureBoxArrowUp
            // 
            this.iconPictureBoxArrowUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.iconPictureBoxArrowUp.ForeColor = System.Drawing.Color.SeaGreen;
            this.iconPictureBoxArrowUp.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconPictureBoxArrowUp.IconColor = System.Drawing.Color.SeaGreen;
            this.iconPictureBoxArrowUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxArrowUp.IconSize = 16;
            this.iconPictureBoxArrowUp.Location = new System.Drawing.Point(10, 8);
            this.iconPictureBoxArrowUp.Name = "iconPictureBoxArrowUp";
            this.iconPictureBoxArrowUp.Rotation = 270D;
            this.iconPictureBoxArrowUp.Size = new System.Drawing.Size(17, 16);
            this.iconPictureBoxArrowUp.TabIndex = 8;
            this.iconPictureBoxArrowUp.TabStop = false;
            // 
            // iconPictureBoxArrowDown
            // 
            this.iconPictureBoxArrowDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.iconPictureBoxArrowDown.ForeColor = System.Drawing.Color.Maroon;
            this.iconPictureBoxArrowDown.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconPictureBoxArrowDown.IconColor = System.Drawing.Color.Maroon;
            this.iconPictureBoxArrowDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxArrowDown.IconSize = 16;
            this.iconPictureBoxArrowDown.Location = new System.Drawing.Point(6, 12);
            this.iconPictureBoxArrowDown.Name = "iconPictureBoxArrowDown";
            this.iconPictureBoxArrowDown.Rotation = 90D;
            this.iconPictureBoxArrowDown.Size = new System.Drawing.Size(17, 16);
            this.iconPictureBoxArrowDown.TabIndex = 5;
            this.iconPictureBoxArrowDown.TabStop = false;
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.labelDiff.ForeColor = System.Drawing.Color.Maroon;
            this.labelDiff.Location = new System.Drawing.Point(28, 13);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(34, 14);
            this.labelDiff.TabIndex = 7;
            this.labelDiff.Text = "00%";
            // 
            // gradientPanelHeader
            // 
            this.gradientPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelHeader.Name = "gradientPanelHeader";
            this.gradientPanelHeader.Size = new System.Drawing.Size(250, 54);
            this.gradientPanelHeader.TabIndex = 5;
            // 
            // PassStatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.gradientPanelHeader);
            this.Name = "PassStatPanel";
            this.Size = new System.Drawing.Size(250, 279);
            this.panelBody.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainerMiddle.Panel1.ResumeLayout(false);
            this.splitContainerMiddle.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMiddle)).EndInit();
            this.splitContainerMiddle.ResumeLayout(false);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxArrowUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxArrowDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelShare;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelIncomeHint;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelNumHint;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxArrowUp;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxArrowDown;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.SplitContainer splitContainerMiddle;
        private System.Windows.Forms.SplitContainer splitContainerBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelShareHint;
        private System.Windows.Forms.Panel gradientPanelHeader;
    }
}
