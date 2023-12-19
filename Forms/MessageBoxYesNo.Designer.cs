namespace MyMessageBox
{
    partial class MessageBoxYesNo
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
            this.footerPnl = new System.Windows.Forms.Panel();
            this.oui = new System.Windows.Forms.Button();
            this.Non = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.bodyPnl = new System.Windows.Forms.Panel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.typePicBox = new System.Windows.Forms.PictureBox();
            this.footerPnl.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.bodyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // footerPnl
            // 
            this.footerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(5)))));
            this.footerPnl.Controls.Add(this.oui);
            this.footerPnl.Controls.Add(this.Non);
            this.footerPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPnl.Location = new System.Drawing.Point(0, 122);
            this.footerPnl.Name = "footerPnl";
            this.footerPnl.Size = new System.Drawing.Size(371, 31);
            this.footerPnl.TabIndex = 0;
            this.footerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.footerPnl_Paint);
            // 
            // oui
            // 
            this.oui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.oui.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.oui.FlatAppearance.BorderSize = 0;
            this.oui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oui.ForeColor = System.Drawing.SystemColors.Control;
            this.oui.Location = new System.Drawing.Point(111, 0);
            this.oui.Name = "oui";
            this.oui.Size = new System.Drawing.Size(85, 25);
            this.oui.TabIndex = 1;
            this.oui.Text = "Yes";
            this.oui.UseVisualStyleBackColor = false;
            this.oui.Click += new System.EventHandler(this.btnYes_Click);
            this.oui.MouseEnter += new System.EventHandler(this.btnYes_MouseEnter);
            this.oui.MouseLeave += new System.EventHandler(this.btnYes_MouseLeave);
            // 
            // Non
            // 
            this.Non.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.Non.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Non.FlatAppearance.BorderSize = 0;
            this.Non.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Non.ForeColor = System.Drawing.SystemColors.Control;
            this.Non.Location = new System.Drawing.Point(202, 0);
            this.Non.Name = "Non";
            this.Non.Size = new System.Drawing.Size(85, 25);
            this.Non.TabIndex = 0;
            this.Non.Text = "No";
            this.Non.UseVisualStyleBackColor = false;
            this.Non.Click += new System.EventHandler(this.btnOk_Click);
            this.Non.MouseEnter += new System.EventHandler(this.btnOk_MouseEnter);
            this.Non.MouseLeave += new System.EventHandler(this.btnOk_MouseLeave);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(5)))));
            this.pnlTitleBar.Controls.Add(this.titleLbl);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(371, 28);
            this.pnlTitleBar.TabIndex = 10;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(11, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(36, 18);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(343, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bodyPnl
            // 
            this.bodyPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(5)))));
            this.bodyPnl.Controls.Add(this.typePicBox);
            this.bodyPnl.Controls.Add(this.messageLbl);
            this.bodyPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPnl.Location = new System.Drawing.Point(0, 28);
            this.bodyPnl.Name = "bodyPnl";
            this.bodyPnl.Size = new System.Drawing.Size(371, 94);
            this.bodyPnl.TabIndex = 11;
            this.bodyPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPnl_Paint);
            // 
            // messageLbl
            // 
            this.messageLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(5)))));
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.messageLbl.Location = new System.Drawing.Point(108, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(263, 94);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.Text = "This is message box";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLbl.Click += new System.EventHandler(this.messageLbl_Click);
            // 
            // typePicBox
            // 
            this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_question_mark_50;
            this.typePicBox.Location = new System.Drawing.Point(3, 6);
            this.typePicBox.Name = "typePicBox";
            this.typePicBox.Size = new System.Drawing.Size(107, 82);
            this.typePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.typePicBox.TabIndex = 1;
            this.typePicBox.TabStop = false;
            this.typePicBox.Click += new System.EventHandler(this.typePicBox_Click);
            // 
            // MessageBoxYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(371, 153);
            this.Controls.Add(this.bodyPnl);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.footerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxYesNo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxCustom";
            this.footerPnl.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.bodyPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footerPnl;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel bodyPnl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.PictureBox typePicBox;
        public System.Windows.Forms.Button Non;
        public System.Windows.Forms.Button oui;
    }
}