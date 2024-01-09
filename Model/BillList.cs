using MyMessageBox;
using Restaurant_Management_System.Forms;
using Restaurant_Management_System.Report;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Model
{
    public partial class BillList : SampleAdd
    {
        public int MainID = 0;
        public BillList()
        {
            InitializeComponent();
        }

        private void BillList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string qry = @"select MainID,TableName, WaiterName,orderType,status, total  from tblMain where status <> 'Pending' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvwaiter);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvtotal);
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;

            }
        }



        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                //frm.ShowDialog();
                this.Close();

                //  MessageBoxSuccess.Show("Edition Successfully", "Edit");






            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                MainClass.con.Close();
                //print Bill
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);

                string qry = @"Select * from tblMain m inner join
                                tblDetails d on d.MainID = m.MainID
                                inner join products p on p.pID  = d.proID
                                where m.MainID = "+MainID+ " ";
                SqlCommand cmd =new SqlCommand (qry, MainClass.con);
                MainClass.con.Open();
                DataTable dt =new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MainClass.con.Close();

                Print frm = new Print();
                rptBill cr = new rptBill();

                cr.SetDatabaseLogon("sa","123");
                cr.SetDataSource(dt);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.crystalReportViewer1.Refresh();
                frm.Show();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}