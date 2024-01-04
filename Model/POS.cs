using MyMessageBox;
using Restaurant_Management_System.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Restaurant_Management_System.Model
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        public int DriverID = 0;
        public string OrderType ="";
        public int MainID = 0;
        public string customerName = "";
        public string customerPhone = "";
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProduct();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CategoryPanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();
                    //evgen for click
                    b.Click += new EventHandler(b_Click);
                    CategoryPanel.Controls.Add(b);

                }

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if (b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());

            }
        }

        private void AddItems(string id, string proID, string name, string cat, string price, Image pImage)
        {

            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pImage,
                id = Convert.ToInt32(proID)
            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    // this will check it product already there then a one to qantity and update price
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = (int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1).ToString();
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return
                        ;
                    }
                }

                // this line add new product first 0 for Sr# et  second 0 from id
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };


        }


        private void LoadProduct()
        {
            string qry = "Select * from products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])(item["pImage"]);

                Byte[] imageByteArray = imageArray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                       item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));

            }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());

            }

        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
                GetTotal();

            }
        }
        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = total.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00.00";

        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Delivery ";


            AddCustomer frm = new AddCustomer();
            frm.MainID = MainID;
            frm.OrderType = OrderType;

            MainClass.BlurBackground(frm);
            if (frm.txtName.Text != "")// comme take away n'a pas d'info sur le driver
            {
                DriverID = frm.DriverID;
                lblDriverName.Text = " Customer Name: " + frm.txtName.Text + "  Phone: " + frm.txtPhone.Text + "  Driver:  " + frm.cbDriver.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone = frm.txtPhone.Text;

            }

        }

        private void btnTake_Click(object sender, EventArgs e)
        {

            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
            AddCustomer frm = new AddCustomer();
            frm.MainID = MainID; 
            frm.OrderType = OrderType; 

            MainClass.BlurBackground(frm);
            if (frm.txtName.Text != "")// comme take away n'a pas d'info sur le driver
            {
                DriverID =frm.DriverID;
                lblDriverName.Text = " Customer Name: "+frm.txtName.Text+" Phone: "+frm.txtPhone.Text;
                lblDriverName.Visible = true;
                customerName = frm.txtName.Text;
                customerPhone= frm.txtPhone.Text;
            }
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "Din In";
            lblDriverName.Visible = false;


            //need to create form for table selection and Waiter selection
            TableSelect frm = new TableSelect();
            MainClass.BlurBackground(frm);
            if (frm.TableName != "")
            {
                lblTable.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;


            }
            WaiterSelect frm2 = new WaiterSelect();
            MainClass.BlurBackground(frm2);
            if (frm2.WaiterName != "")
            {
                lblWaiter.Text = frm2.WaiterName;
                lblWaiter.Visible = true;

            }
            else
            {
                lblWaiter.Text = "";

                lblWaiter.Visible = false;
            }
        }
        private void btnKot_Click(object sender, EventArgs e)
        {

            // Sauvegarder les données dans la base de données
            // Créer la table principale
            string qry1 = ""; // Table principale
                              // Table de détails
                              // Créer la commande pour la table principale

            // Définir les paramètres pour la table principale

            // Opération d'insertion, exclure MainID

            int detailID = 0;
            if (OrderType == "")
            {
                MessageBoxGunaOk.Show("Please select a order type ", "RMS", MessageBoxType.OK);
                return;

            }
            if (guna2DataGridView1.Rows.Count == 0)
            {
                MessageBoxGunaOk.Show("Veuillez sélectionner au moins un produit", "RMS", MessageBoxType.OK);
                return;
            }

            if (MainID == 0)
            {
                // Opération d'insertion pour la table principale
                qry1 = "INSERT INTO tblMain VALUES" +
                       "(@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change, @driverID, @CustName, @CustPhone);" +
                       "SELECT SCOPE_IDENTITY()";
            }
            else
            {
                // Opération de mise à jour pour la table principale
                qry1 = "UPDATE tblMain SET status = @status, orderType = @orderType, total = @total, received = @received, change = @change WHERE MainID = @ID";
            }

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);
            // Opération de mise à jour, inclure MainID
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", DriverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);




            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); }
            else { cmd.ExecuteNonQuery(); }

            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                // Déplacer la déclaration de qry2 ici
                string qry2 = ""; // Table de détails

                SqlCommand cmd2;

                if (detailID == 0)
                {
                    // Opération d'insertion pour la table de détails
                    qry2 = "INSERT INTO tblDetails VALUES" +
                           "(@MainID, @proID, @qty, @price, @amount);" +
                           "SELECT SCOPE_IDENTITY()";

                }
                else
                {
                    // Opération de mise à jour pour la table de détails
                    qry2 = "UPDATE tblDetails SET proID = @proID, qty = @qty, price = @price, amount = @amount WHERE DetailID = @DetailID";

                    // Ajoutez cette ligne pour déclarer et définir le paramètre @DetailID dans le cas où MainID est différent de zéro
                }
                cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);

                // Définir les paramètres pour la table de détails
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@DetailID",detailID );

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }

                // Exécuter la commande
                cmd2.ExecuteNonQuery(); 

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }
            MessageBoxGunaOk.Show("Enregistré avec succès... ", "RMS ", MessageBoxType.Succes);

            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();

            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00.00";
            lblDriverName.Text = "";
            btnDelivery.Checked = false;
            btnDin.Checked = false;
            btnTake.Checked = false;

        }
        public int id = 0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            BillList frm = new BillList();
            MainClass.BlurBackground(frm);
            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }
        }


        private void LoadEntries()
        {
            string qry = @"Select * from tblMain m 
                    inner join tblDetails d on m.MainID = d.MainID 
                    inner join products p on p.pID = d.proID Where m.MainID = " + id + "";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows.Count > 0) // Check if there are rows in the DataTable
            {
                DataRow firstRow = dt2.Rows[0]; // Access the first row for orderType check

                if (firstRow["orderType"].ToString() == "Delivery")
                {
                    btnDelivery.Checked = true;
                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }
                else if (firstRow["orderType"].ToString() == "Take Away")
                {
                    btnTake.Checked = true;
                    lblWaiter.Visible = false;
                    lblTable.Visible = false;
                }
                else
                {
                    btnDin.Checked = true;
                    lblWaiter.Visible = true;
                    lblTable.Visible = true;
                }

                guna2DataGridView1.Rows.Clear();

                foreach (DataRow item in dt2.Rows)
                {
                    lblTable.Text = item["TableName"].ToString();
                    lblWaiter.Text = item["WaiterName"].ToString();
                    string detailid = item["DetailID"].ToString();
                    string proid = item["proID"].ToString();
                    string proName = item["pName"].ToString();
                    string qty = item["qty"].ToString();
                    string price = item["price"].ToString();
                    string amount = item["amount"].ToString();
                    object[] obj = { 0, detailid, proid, proName, qty, price, amount };
                    guna2DataGridView1.Rows.Add(obj);
                }

                GetTotal();
            }
            else
            {
                // Handle the case when there are no rows in the DataTable
                // You may want to show a message or take appropriate action
            }
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout frm = new Checkout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);
            MainID = 0;
            guna2DataGridView1.Rows.Clear();

            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00.00";

        }

        private void btnHold_Click(object sender, EventArgs e)
        {

            // Sauvegarder les données dans la base de données
            // Créer la table principale
            string qry1 = ""; // Table principale
                              // Table de détails
            int detailID = 0;
            if (OrderType == "" )
            {
                MessageBoxGunaOk.Show("Please select  order type ", " ", MessageBoxType.OK);
                return;

            }

             if (guna2DataGridView1.Rows.Count == 0)
            {
                MessageBoxGunaOk.Show("Veuillez sélectionner au moins un produit", "RMS", MessageBoxType.OK);
                return;
            }

            if (MainID == 0)
            {
                // Opération d'insertion pour la table principale
                qry1 = "INSERT INTO tblMain VALUES" +
                       "(@aDate, @aTime, @TableName, @WaiterName, @status, @orderType, @total, @received, @change, @driverID, @CustName, @CustPhone);" +
                       "SELECT SCOPE_IDENTITY()";
            }
            else
            {
                // Opération de mise à jour pour la table principale
                qry1 = "UPDATE tblMain SET status = @status, orderType = @orderType, total = @total, received = @received, change = @change WHERE MainID = @ID";
            }

            // Créer la commande pour la table principale
            SqlCommand cmd = new SqlCommand(qry1, MainClass.con);

            // Définir les paramètres pour la table principale

            // Opération d'insertion, exclure MainID

            // Opération de mise à jour, inclure MainID
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lblWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Hold");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@driverID", DriverID);
            cmd.Parameters.AddWithValue("@CustName", customerName);
            cmd.Parameters.AddWithValue("@CustPhone", customerPhone);


            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }

            // Exécuter la commande
            if (MainID == 0) { MainID = Convert.ToInt32(cmd.ExecuteScalar()); }
            else { cmd.ExecuteNonQuery(); }

            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                // Déplacer la déclaration de qry2 ici
                string qry2 = ""; // Table de détails

                SqlCommand cmd2;

                if (detailID == 0)
                {
                    // Opération d'insertion pour la table de détails
                    qry2 = "INSERT INTO tblDetails VALUES" +
                           "(@MainID, @proID, @qty, @price, @amount);" +
                           "SELECT SCOPE_IDENTITY()";

                }
                else
                {
                    // Opération de mise à jour pour la table de détails
                    qry2 = "UPDATE tblDetails SET proID = @proID, qty = @qty, price = @price, amount = @amount WHERE DetailID = @DetailID";

                    // Ajoutez cette ligne pour déclarer et définir le paramètre @DetailID dans le cas où MainID est différent de zéro
                }
                cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);

                // Définir les paramètres pour la table de détails
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }

                // Exécuter la commande
                cmd2.ExecuteNonQuery();

                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            }
            MessageBoxGunaOk.Show("Enregistré avec succès... ", "RMS", MessageBoxType.Succes);

            MainID = 0;
            detailID = 0;
            guna2DataGridView1.Rows.Clear();
          
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            lblTotal.Text = "00.00";
            lblDriverName.Text = "";

            btnDelivery.Checked = false;
            btnDin.Checked = false;
            btnTake.Checked = false;
        }

        private void lblDriverName_Click(object sender, EventArgs e)
        {

        }
    }
}
