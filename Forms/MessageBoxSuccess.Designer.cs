namespace Restaurant_Management_System.Forms
{
    partial class MessageBoxSuccess
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
            this.messageLbl = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.footerPnl = new System.Windows.Forms.Panel();
            this.typePicBox = new System.Windows.Forms.PictureBox();
            this.pnlTitleBar.SuspendLayout();
            this.bodyPnl.SuspendLayout();
            this.footerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlTitleBar.Controls.Add(this.titleLbl);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(373, 28);
            this.pnlTitleBar.TabIndex = 13;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(11, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(52, 20);
            this.titleLbl.TabIndex = 16;
            this.titleLbl.Text = "Erreur";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(345, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bodyPnl
            // 
            this.bodyPnl.BackColor = System.Drawing.Color.ForestGreen;
            this.bodyPnl.Controls.Add(this.typePicBox);
            this.bodyPnl.Controls.Add(this.messageLbl);
            this.bodyPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPnl.Location = new System.Drawing.Point(0, 0);
            this.bodyPnl.Name = "bodyPnl";
            this.bodyPnl.Size = new System.Drawing.Size(373, 117);
            this.bodyPnl.TabIndex = 14;
            // 
            // messageLbl
            // 
            this.messageLbl.BackColor = System.Drawing.Color.ForestGreen;
            this.messageLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.messageLbl.Location = new System.Drawing.Point(112, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(261, 117);
            this.messageLbl.TabIndex = 0;
            this.messageLbl.Text = "Identifiant ou mot de passe incorrect";
            this.messageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageLbl.Click += new System.EventHandler(this.messageLbl_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOk.Location = new System.Drawing.Point(149, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 25);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // footerPnl
            // 
            this.footerPnl.BackColor = System.Drawing.Color.ForestGreen;
            this.footerPnl.Controls.Add(this.btnOk);
            this.footerPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPnl.Location = new System.Drawing.Point(0, 117);
            this.footerPnl.Name = "footerPnl";
            this.footerPnl.Size = new System.Drawing.Size(373, 36);
            this.footerPnl.TabIndex = 12;
            // 
            // typePicBox
            // 
            this.typePicBox.ErrorImage = global::Restaurant_Management_System.Properties.Resources.icons8_danger_96;
            this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_verified_check_circle_for_approved_valid_content_96;
            this.typePicBox.Location = new System.Drawing.Point(12, 34);
            this.typePicBox.Name = "typePicBox";
            this.typePicBox.Size = new System.Drawing.Size(92, 65);
            this.typePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.typePicBox.TabIndex = 2;
            this.typePicBox.TabStop = false;
            // 
            // MessageBoxSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 153);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.bodyPnl);
            this.Controls.Add(this.footerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxSuccess";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.bodyPnl.ResumeLayout(false);
            this.footerPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel bodyPnl;
        private System.Windows.Forms.PictureBox typePicBox;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel footerPnl;
    }
}