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

namespace Restaurant_Management_System.Report
{
    public partial class SaleByCategory : Form
    {
        public SaleByCategory()
        {
            InitializeComponent();
        }

        private void SaleByCategory_Load(object sender, EventArgs e)
        {

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            //string qry = @"Select * from staff ";
           //SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            MainClass.con.Open();
            DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
           // da.Fill(dt);
            MainClass.con.Close();

            Print frm = new Print();
            rptStaff cr = new rptStaff();

            cr.SetDatabaseLogon("sa", "123");
            cr.SetDataSource(dt);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.crystalReportViewer1.Refresh();
            frm.Show();
        }
    }
}
