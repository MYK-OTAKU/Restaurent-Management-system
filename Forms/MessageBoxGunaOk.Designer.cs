namespace Restaurant_Management_System.Forms
{
    partial class MessageBoxGunaOk
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
            this.btnOk = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.footerPnl = new System.Windows.Forms.Panel();
            this.typePicBox = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            this.footerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.CheckedState.Parent = this.btnOk;
            this.btnOk.CustomImages.Parent = this.btnOk;
            this.btnOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.HoverState.Parent = this.btnOk;
            this.btnOk.Location = new System.Drawing.Point(215, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.ShadowDecoration.Parent = this.btnOk;
            this.btnOk.Size = new System.Drawing.Size(100, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.Controls.Add(this.titleLbl);
            this.pnlTitleBar.Location = new System.Drawing.Point(104, 22);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(99, 28);
            this.pnlTitleBar.TabIndex = 11;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(44, 21);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.messageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.Color.White;
            this.messageLbl.Location = new System.Drawing.Point(104, 53);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(235, 32);
            this.messageLbl.TabIndex = 17;
            this.messageLbl.Text = "This is message box";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLbl.Click += new System.EventHandler(this.messageLbl_Click);
            // 
            // footerPnl
            // 
            this.footerPnl.BackColor = System.Drawing.Color.Transparent;
            this.footerPnl.Controls.Add(this.btnOk);
            this.footerPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPnl.Location = new System.Drawing.Point(0, 91);
            this.footerPnl.Name = "footerPnl";
            this.footerPnl.Size = new System.Drawing.Size(339, 52);
            this.footerPnl.TabIndex = 18;
            // 
            // typePicBox
            // 
            this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_info_96;
            this.typePicBox.Location = new System.Drawing.Point(12, 12);
            this.typePicBox.Name = "typePicBox";
            this.typePicBox.Size = new System.Drawing.Size(86, 73);
            this.typePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typePicBox.TabIndex = 1;
            this.typePicBox.TabStop = false;
            // 
            // MessageBoxGunaOk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(339, 143);
            this.Controls.Add(this.footerPnl);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.typePicBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxGunaOk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxGunaOk";
            this.Load += new System.EventHandler(this.MessageBoxGunaOk_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.footerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOk;
        private System.Windows.Forms.PictureBox typePicBox;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Panel footerPnl;
    }
}