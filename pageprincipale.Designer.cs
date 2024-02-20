namespace Restaurant_Management_System
{
    partial class pageprincipale
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.unamee = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.btnkit = new Guna.UI2.WinForms.Guna2Button();
            this.btnpos = new Guna.UI2.WinForms.Guna2Button();
            this.btnstaff = new Guna.UI2.WinForms.Guna2Button();
            this.btntable = new Guna.UI2.WinForms.Guna2Button();
            this.btnprod = new Guna.UI2.WinForms.Guna2Button();
            this.btncate = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "POS System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unamee
            // 
            this.unamee.AutoSize = true;
            this.unamee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamee.Location = new System.Drawing.Point(6, 12);
            this.unamee.Name = "unamee";
            this.unamee.Size = new System.Drawing.Size(88, 21);
            this.unamee.TabIndex = 3;
            this.unamee.Text = "User Name";
            this.unamee.Click += new System.EventHandler(this.unamee_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.guna2Separator1);
            this.guna2Panel2.Controls.Add(this.unamee);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel2.Location = new System.Drawing.Point(195, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(975, 57);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 49);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(975, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnreport);
            this.guna2Panel1.Controls.Add(this.btnkit);
            this.guna2Panel1.Controls.Add(this.btnpos);
            this.guna2Panel1.Controls.Add(this.btnstaff);
            this.guna2Panel1.Controls.Add(this.btntable);
            this.guna2Panel1.Controls.Add(this.btnprod);
            this.guna2Panel1.Controls.Add(this.btncate);
            this.guna2Panel1.Controls.Add(this.btnhome);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(195, 633);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(51, 570);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(96, 36);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "Exit";
            this.guna2Button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.guna2Button1.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_installing_updates_96_pngQ;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Restaurant_Management_System.Properties.Resources.icons8_installing_updates_96;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(42, 439);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(153, 37);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Paramètre";
            this.guna2Button1.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnreport
            // 
            this.btnreport.AutoRoundedCorners = true;
            this.btnreport.BorderRadius = 17;
            this.btnreport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnreport.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnreport.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_order_completed_90_pngN;
            this.btnreport.CheckedState.Parent = this.btnreport;
            this.btnreport.CustomImages.Parent = this.btnreport;
            this.btnreport.FillColor = System.Drawing.Color.Transparent;
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.HoverState.Parent = this.btnreport;
            this.btnreport.Image = global::Restaurant_Management_System.Properties.Resources.icons8_order_completed_90;
            this.btnreport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnreport.Location = new System.Drawing.Point(42, 396);
            this.btnreport.Name = "btnreport";
            this.btnreport.ShadowDecoration.Parent = this.btnreport;
            this.btnreport.Size = new System.Drawing.Size(153, 37);
            this.btnreport.TabIndex = 9;
            this.btnreport.Text = "Stats";
            this.btnreport.TextOffset = new System.Drawing.Point(10, 0);
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnkit
            // 
            this.btnkit.AutoRoundedCorners = true;
            this.btnkit.BorderRadius = 17;
            this.btnkit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnkit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnkit.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_chef_hat_j;
            this.btnkit.CheckedState.Parent = this.btnkit;
            this.btnkit.CustomImages.Parent = this.btnkit;
            this.btnkit.FillColor = System.Drawing.Color.Transparent;
            this.btnkit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkit.ForeColor = System.Drawing.Color.White;
            this.btnkit.HoverState.Parent = this.btnkit;
            this.btnkit.Image = global::Restaurant_Management_System.Properties.Resources.b;
            this.btnkit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnkit.Location = new System.Drawing.Point(42, 353);
            this.btnkit.Name = "btnkit";
            this.btnkit.ShadowDecoration.Parent = this.btnkit;
            this.btnkit.Size = new System.Drawing.Size(153, 37);
            this.btnkit.TabIndex = 8;
            this.btnkit.Text = "Cuisine";
            this.btnkit.TextOffset = new System.Drawing.Point(10, 0);
            this.btnkit.Click += new System.EventHandler(this.btnkit_Click);
            // 
            // btnpos
            // 
            this.btnpos.AutoRoundedCorners = true;
            this.btnpos.BorderRadius = 17;
            this.btnpos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnpos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnpos.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_pos_96__1_;
            this.btnpos.CheckedState.Parent = this.btnpos;
            this.btnpos.CustomImages.Parent = this.btnpos;
            this.btnpos.FillColor = System.Drawing.Color.Transparent;
            this.btnpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpos.ForeColor = System.Drawing.Color.White;
            this.btnpos.HoverState.Parent = this.btnpos;
            this.btnpos.Image = global::Restaurant_Management_System.Properties.Resources.icons8_pos_96;
            this.btnpos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnpos.Location = new System.Drawing.Point(42, 310);
            this.btnpos.Name = "btnpos";
            this.btnpos.ShadowDecoration.Parent = this.btnpos;
            this.btnpos.Size = new System.Drawing.Size(153, 37);
            this.btnpos.TabIndex = 7;
            this.btnpos.Text = "POS";
            this.btnpos.TextOffset = new System.Drawing.Point(10, 0);
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.AutoRoundedCorners = true;
            this.btnstaff.BorderRadius = 17;
            this.btnstaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnstaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnstaff.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_name_tag_50_png2;
            this.btnstaff.CheckedState.Parent = this.btnstaff;
            this.btnstaff.CustomImages.Parent = this.btnstaff;
            this.btnstaff.FillColor = System.Drawing.Color.Transparent;
            this.btnstaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.HoverState.Parent = this.btnstaff;
            this.btnstaff.Image = global::Restaurant_Management_System.Properties.Resources.icons8_name_tag_50;
            this.btnstaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnstaff.Location = new System.Drawing.Point(42, 267);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.ShadowDecoration.Parent = this.btnstaff;
            this.btnstaff.Size = new System.Drawing.Size(153, 37);
            this.btnstaff.TabIndex = 6;
            this.btnstaff.Text = "Staffs";
            this.btnstaff.TextOffset = new System.Drawing.Point(10, 0);
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // btntable
            // 
            this.btntable.AutoRoundedCorners = true;
            this.btntable.BorderRadius = 17;
            this.btntable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btntable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btntable.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_table_100_pngb;
            this.btntable.CheckedState.Parent = this.btntable;
            this.btntable.CustomImages.Parent = this.btntable;
            this.btntable.FillColor = System.Drawing.Color.Transparent;
            this.btntable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntable.ForeColor = System.Drawing.Color.White;
            this.btntable.HoverState.Parent = this.btntable;
            this.btntable.Image = global::Restaurant_Management_System.Properties.Resources.icons8_table_1002;
            this.btntable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btntable.Location = new System.Drawing.Point(42, 224);
            this.btntable.Name = "btntable";
            this.btntable.ShadowDecoration.Parent = this.btntable;
            this.btntable.Size = new System.Drawing.Size(153, 37);
            this.btntable.TabIndex = 5;
            this.btntable.Text = "Tables";
            this.btntable.TextOffset = new System.Drawing.Point(10, 0);
            this.btntable.Click += new System.EventHandler(this.btntable_Click);
            // 
            // btnprod
            // 
            this.btnprod.AutoRoundedCorners = true;
            this.btnprod.BorderRadius = 17;
            this.btnprod.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnprod.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnprod.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_package_26w__1_;
            this.btnprod.CheckedState.Parent = this.btnprod;
            this.btnprod.CustomImages.Parent = this.btnprod;
            this.btnprod.FillColor = System.Drawing.Color.Transparent;
            this.btnprod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprod.ForeColor = System.Drawing.Color.White;
            this.btnprod.HoverState.Parent = this.btnprod;
            this.btnprod.Image = global::Restaurant_Management_System.Properties.Resources.icons8_package_26;
            this.btnprod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprod.Location = new System.Drawing.Point(42, 181);
            this.btnprod.Name = "btnprod";
            this.btnprod.ShadowDecoration.Parent = this.btnprod;
            this.btnprod.Size = new System.Drawing.Size(153, 37);
            this.btnprod.TabIndex = 4;
            this.btnprod.Text = "Produits";
            this.btnprod.TextOffset = new System.Drawing.Point(10, 0);
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // btncate
            // 
            this.btncate.AutoRoundedCorners = true;
            this.btncate.BorderRadius = 17;
            this.btncate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btncate.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.icons8_medium_priority_100_pngs;
            this.btncate.CheckedState.Parent = this.btncate;
            this.btncate.CustomImages.Parent = this.btncate;
            this.btncate.FillColor = System.Drawing.Color.Transparent;
            this.btncate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncate.ForeColor = System.Drawing.Color.White;
            this.btncate.HoverState.Parent = this.btncate;
            this.btncate.Image = global::Restaurant_Management_System.Properties.Resources.icons8_medium_priority_48;
            this.btncate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncate.Location = new System.Drawing.Point(42, 138);
            this.btncate.Name = "btncate";
            this.btncate.ShadowDecoration.Parent = this.btncate;
            this.btncate.Size = new System.Drawing.Size(153, 37);
            this.btncate.TabIndex = 3;
            this.btncate.Text = "Catégories";
            this.btncate.TextOffset = new System.Drawing.Point(10, 0);
            this.btncate.Click += new System.EventHandler(this.btncate_Click);
            // 
            // btnhome
            // 
            this.btnhome.AutoRoundedCorners = true;
            this.btnhome.BorderRadius = 17;
            this.btnhome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnhome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnhome.CheckedState.Image = global::Restaurant_Management_System.Properties.Resources.SS;
            this.btnhome.CheckedState.Parent = this.btnhome;
            this.btnhome.CustomImages.Parent = this.btnhome;
            this.btnhome.FillColor = System.Drawing.Color.Transparent;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.Parent = this.btnhome;
            this.btnhome.Image = global::Restaurant_Management_System.Properties.Resources.icons8_home_64;
            this.btnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnhome.Location = new System.Drawing.Point(42, 95);
            this.btnhome.Name = "btnhome";
            this.btnhome.ShadowDecoration.Parent = this.btnhome;
            this.btnhome.Size = new System.Drawing.Size(153, 37);
            this.btnhome.TabIndex = 2;
            this.btnhome.Text = "Acceuil";
            this.btnhome.TextOffset = new System.Drawing.Point(10, 0);
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AutoRoundedCorners = true;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 26;
            this.guna2PictureBox1.ErrorImage = global::Restaurant_Management_System.Properties.Resources.icons8_restaurant_100_pngS;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Restaurant_Management_System.Properties.Resources.icons8_restaurant_1001;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 12);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 54);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel.AutoRoundedCorners = true;
            this.CenterPanel.BackColor = System.Drawing.Color.White;
            this.CenterPanel.BorderColor = System.Drawing.Color.White;
            this.CenterPanel.BorderRadius = 284;
            this.CenterPanel.BorderThickness = 1;
            this.CenterPanel.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.CenterPanel.Location = new System.Drawing.Point(201, 63);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.ShadowDecoration.Parent = this.CenterPanel;
            this.CenterPanel.Size = new System.Drawing.Size(969, 570);
            this.CenterPanel.TabIndex = 5;
            this.CenterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CenterPanel_Paint);
            // 
            // guna2AnimateWindow2
            // 
            this.guna2AnimateWindow2.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            this.guna2AnimateWindow2.Interval = 500;
            // 
            // pageprincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1170, 633);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.CenterPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pageprincipale";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pageprincipale_Load_1);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnreport;
        private Guna.UI2.WinForms.Guna2Button btnkit;
        private Guna.UI2.WinForms.Guna2Button btnpos;
        private Guna.UI2.WinForms.Guna2Button btnstaff;
        private Guna.UI2.WinForms.Guna2Button btntable;
        private System.Windows.Forms.Label unamee;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnprod;
        private Guna.UI2.WinForms.Guna2Button btncate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}