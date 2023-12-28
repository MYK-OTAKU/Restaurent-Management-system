using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.View
{
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status ='Pending'";
            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);
            FlowLayoutPanel p1;







            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();


                p2 = new FlowLayoutPanel();
                p2.AutoSize = true;
                p2.BackColor = Color.FromArgb(50, 55, 89);
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0, 0, 0, 0);


                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 5, 3, 0);
                lb1.AutoSize = true;



                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;


                Label lb5 = new Label();
                lb5.ForeColor = Color.White;
                lb5.Margin = new Padding(10, 5, 3, 0);
                lb5.AutoSize = true;


                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.AutoSize = true;



                lb1.Text = "Table : " + dt1.Rows[i]["TableName"].ToString();
                lb2.Text = "Waiter Name  : " + dt1.Rows[i]["WaiterName"].ToString();
                lb3.Text = "order Time : " + dt1.Rows[i]["aTime"].ToString();
                lb4.Text = "order Date : " + dt1.Rows[i]["aDate"].ToString();
                lb5.Text = "order Type : " + dt1.Rows[i]["orderType"].ToString();


                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);
                p2.Controls.Add(lb5);

                p1.Controls.Add(p2);
                flowLayoutPanel1.Controls.Add(p1);
            }
        }
    }
}
