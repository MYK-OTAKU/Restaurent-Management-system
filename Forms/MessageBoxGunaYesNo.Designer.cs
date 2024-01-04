namespace Restaurant_Management_System.Forms
{
    partial class MessageBoxGunaYesNo
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
            this.btnYES = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.footerPnl = new System.Windows.Forms.Panel();
            this.btnNO = new Guna.UI2.WinForms.Guna2Button();
            this.messageLbl = new System.Windows.Forms.Label();
            this.typePicBox = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            this.footerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYES
            // 
            this.btnYES.CheckedState.Parent = this.btnYES;
            this.btnYES.CustomImages.Parent = this.btnYES;
            this.btnYES.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYES.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYES.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.Color.White;
            this.btnYES.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYES.HoverState.Parent = this.btnYES;
            this.btnYES.Location = new System.Drawing.Point(166, 6);
            this.btnYES.Name = "btnYES";
            this.btnYES.ShadowDecoration.Parent = this.btnYES;
            this.btnYES.Size = new System.Drawing.Size(91, 34);
            this.btnYES.TabIndex = 0;
            this.btnYES.Text = "Yes";
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.Controls.Add(this.titleLbl);
            this.pnlTitleBar.Location = new System.Drawing.Point(104, 11);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(66, 28);
            this.pnlTitleBar.TabIndex = 20;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(44, 21);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "RMS";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footerPnl
            // 
            this.footerPnl.BackColor = System.Drawing.Color.Transparent;
            this.footerPnl.Controls.Add(this.btnNO);
            this.footerPnl.Controls.Add(this.btnYES);
            this.footerPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPnl.Location = new System.Drawing.Point(0, 107);
            this.footerPnl.Name = "footerPnl";
            this.footerPnl.Size = new System.Drawing.Size(378, 52);
            this.footerPnl.TabIndex = 22;
            // 
            // btnNO
            // 
            this.btnNO.CheckedState.Parent = this.btnNO;
            this.btnNO.CustomImages.Parent = this.btnNO;
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNO.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.ForeColor = System.Drawing.Color.White;
            this.btnNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNO.HoverState.Parent = this.btnNO;
            this.btnNO.Location = new System.Drawing.Point(275, 6);
            this.btnNO.Name = "btnNO";
            this.btnNO.ShadowDecoration.Parent = this.btnNO;
            this.btnNO.Size = new System.Drawing.Size(91, 34);
            this.btnNO.TabIndex = 1;
            this.btnNO.Text = "No";
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.messageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageLbl.Location = new System.Drawing.Point(104, 42);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(235, 32);
            this.messageLbl.TabIndex = 21;
            this.messageLbl.Text = "This is message box";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLbl.Click += new System.EventHandler(this.messageLbl_Click);
            // 
            // typePicBox
            // 
            this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_question_100;
            this.typePicBox.Location = new System.Drawing.Point(12, 11);
            this.typePicBox.Name = "typePicBox";
            this.typePicBox.Size = new System.Drawing.Size(86, 63);
            this.typePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typePicBox.TabIndex = 19;
            this.typePicBox.TabStop = false;
            // 
            // MessageBoxGunaYesNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(378, 159);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.footerPnl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.typePicBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxGunaYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessavgeBoxGunaY6esNo";
            this.Load += new System.EventHandler(this.MessageBoxGunaYesNo_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.footerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnYES;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel footerPnl;
        private Guna.UI2.WinForms.Guna2Button btnNO;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.PictureBox typePicBox;
    }
}