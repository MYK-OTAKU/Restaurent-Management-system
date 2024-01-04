using Guna.UI2.WinForms;
using MvvmDialogs.FrameworkDialogs.MessageBox;
using MyMessageBox;
using Restaurant_Management_System.Forms;
using Restaurant_Management_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Restaurant_Management_System
{
    public partial class CategoryViews : sampleViews
    {

        public CategoryViews()
        {
            InitializeComponent();
            this.Shown += YourForm_Shown;
        }
        private void YourForm_Shown(object sender, EventArgs e)
        {
            // Met ce code dans l'événement Shown pour garantir qu'il est exécuté après l'affichage de la fenêtre
            guna2DataGridView1.Columns["dgvSno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvedit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvdel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns["dgvSno"].FillWeight = 1;
            guna2DataGridView1.Columns["dgvid"].FillWeight = 1;
            guna2DataGridView1.Columns["dgvName"].FillWeight = 8.5F;
            guna2DataGridView1.Columns["dgvedit"].FillWeight = 0.5f;
            guna2DataGridView1.Columns["dgvdel"].FillWeight = 0.5f;

            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            // CategoryAdd frm = new CategoryAdd();
            // frm.ShowDialog();
            MainClass.BlurBackground(new CategoryAdd());

            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                CategoryAdd frm = new CategoryAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                //frm.ShowDialog();
                MainClass.BlurBackground(frm);

                GetData();
                //  MessageBoxSuccess.Show("Edition Successfully", "Edit");

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // Affiche la boîte de dialogue
                if (MessageBoxGunaYesNo.Show("Are you sure you want to delete", "RMS", MessageBoxType.Question) == DialogResult.Yes)
                {
                    // Si le bouton "Yes" est pressé, effectue la suppression
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "DELETE FROM category WHERE catID = " + id;
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    GetData();
                    MessageBoxGunaOk.Show("Deleted Successfully ... ", "RMS", MessageBoxType.Succes);

                }


            }



        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
