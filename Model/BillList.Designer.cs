namespace Restaurant_Management_System.Model
{
    partial class BillList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvwaiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.CustomImages.Parent = this.BtnClose;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // BtnSave
            // 
            this.BtnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.BtnSave.CheckedState.Parent = this.BtnSave;
            this.BtnSave.CustomImages.Parent = this.BtnSave;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSave.HoverState.Parent = this.BtnSave;
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.ShadowDecoration.Parent = this.BtnSave;
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.Text = "Liste de Facture";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.icons8_bill_96;
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Location = new System.Drawing.Point(0, 553);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(800, 11);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 103);
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            this.guna2Panel1.Controls.SetChildIndex(this.guna2PictureBox1, 0);
            this.guna2Panel1.Controls.SetChildIndex(this.label1, 0);
            this.guna2Panel1.Controls.SetChildIndex(this.btnExit, 0);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvtable,
            this.dgvwaiter,
            this.dgvtype,
            this.dgvStatus,
            this.dgvtotal,
            this.dgvid,
            this.dgvedit,
            this.dgvdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(22, 149);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            this.guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(755, 382);
            this.guna2DataGridView1.TabIndex = 11;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(752, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvtable
            // 
            this.dgvtable.HeaderText = "Table";
            this.dgvtable.Name = "dgvtable";
            this.dgvtable.ReadOnly = true;
            // 
            // dgvwaiter
            // 
            this.dgvwaiter.HeaderText = "Serveur";
            this.dgvwaiter.Name = "dgvwaiter";
            this.dgvwaiter.ReadOnly = true;
            // 
            // dgvtype
            // 
            this.dgvtype.FillWeight = 115F;
            this.dgvtype.HeaderText = "Commande Type";
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status ";
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // dgvtotal
            // 
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = global::Restaurant_Management_System.Properties.Resources.icons8_pencil_96;
            this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvedit.MinimumWidth = 50;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = global::Restaurant_Management_System.Properties.Resources.icons8_print_96;
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // BillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "BillList";
            this.Text = "BillList";
            this.Load += new System.EventHandler(this.BillList_Load);
            this.Controls.SetChildIndex(this.guna2Panel1, 0);
            this.Controls.SetChildIndex(this.guna2Panel2, 0);
            this.Controls.SetChildIndex(this.guna2DataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvwaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}