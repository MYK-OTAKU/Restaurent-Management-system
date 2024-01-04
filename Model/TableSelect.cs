using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Restaurant_Management_System.Model
{
    public partial class TableSelect : Form
    {
        public string TableName;
        public TableSelect()
        {
            InitializeComponent();
        }

        private void TableSelect_Load(object sender, EventArgs e)
        {
            string qry = "select * from tables";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["tname"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.FillColor = Color.FromArgb(241, 85, 126);
                b.HoverState.FillColor = Color.FromArgb(50, 55, 89);

                //even for click
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            TableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}