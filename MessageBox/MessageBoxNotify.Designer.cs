namespace MyMessageBox
{
    partial class MessageBoxNotify
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.bodyPnl = new System.Windows.Forms.Panel();
            this.typePicBox = new System.Windows.Forms.PictureBox();
            this.messageLbl = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.bodyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.pnlTitleBar.Controls.Add(this.titleLbl);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(404, 28);
            this.pnlTitleBar.TabIndex = 10;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(7, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(36, 18);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(376, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bodyPnl
            // 
            this.bodyPnl.Controls.Add(this.typePicBox);
            this.bodyPnl.Controls.Add(this.messageLbl);
            this.bodyPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPnl.Location = new System.Drawing.Point(0, 28);
            this.bodyPnl.Name = "bodyPnl";
            this.bodyPnl.Size = new System.Drawing.Size(404, 94);
            this.bodyPnl.TabIndex = 11;
            // 
            // typePicBox
            // 
            this.typePicBox.Image = global::messagebox.Properties.Resources.info;
            this.typePicBox.Location = new System.Drawing.Point(10, 22);
            this.typePicBox.Name = "typePicBox";
            this.typePicBox.Size = new System.Drawing.Size(55, 55);
            this.typePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.typePicBox.TabIndex = 2;
            this.typePicBox.TabStop = false;
            // 
            // messageLbl
            // 
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.messageLbl.Location = new System.Drawing.Point(74, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(330, 94);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.Text = "This is message box";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLbl.Click += new System.EventHandler(this.messageLbl_Click);
            // 
            // MessageBoxNotify
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(404, 122);
            this.Controls.Add(this.bodyPnl);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxNotify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxCustom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageBoxNotify_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.bodyPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel bodyPnl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.PictureBox typePicBox;
    }
}