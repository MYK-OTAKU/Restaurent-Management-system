using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class CategoryViews : sampleViews
    {
        public CategoryViews()
        {
            InitializeComponent();
        }
        // let create table first 

        public void GetData()
        {
            string qry = " Select * From Category where catName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetData();

        }
        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd frm = new CategoryAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
