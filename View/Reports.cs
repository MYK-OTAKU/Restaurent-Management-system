using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Restaurant_Management_System.Report;


namespace Restaurant_Management_System.View
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            string qry = @"Select * from products ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

            Print frm = new Print();
            rptMenu cr = new rptMenu();

            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            string qry = @"Select * from staff ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MainClass.con.Close();

            Print frm = new Print();
            rptStaff cr = new rptStaff();

            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
            
        }

        private void btnSaleCat_Click(object sender, EventArgs e)
        {
            SaleByCategory frm = new SaleByCategory();
            frm.ShowDialog();
        }
    }
}
