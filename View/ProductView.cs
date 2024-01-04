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

namespace Restaurant_Management_System.View
{
    public partial class ProductView : sampleViews
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            GetData();
            this.Shown += YourForm_Shown;

        }
        private void YourForm_Shown(object sender, EventArgs e)
        {
            // Met ce code dans l'événement Shown pour garantir qu'il est exécuté après l'affichage de la fenêtre
            guna2DataGridView1.Columns["dgvSno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvcatID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvcat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvedit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvdel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns["dgvSno"].FillWeight = 0.5f;
            guna2DataGridView1.Columns["dgvid"].FillWeight = 1;
            guna2DataGridView1.Columns["dgvName"].FillWeight = 3.5F;
            guna2DataGridView1.Columns["dgvcatID"].FillWeight = 1;
            guna2DataGridView1.Columns["dgvPrice"].FillWeight = 2;
            guna2DataGridView1.Columns["dgvcat"].FillWeight = 2;
            guna2DataGridView1.Columns["dgvedit"].FillWeight = 0.5f;
            guna2DataGridView1.Columns["dgvdel"].FillWeight = 0.5f;

            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }



        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            //  tableAdd frm = new tableAdd();
            //  frm.ShowDialog();
            //
            MainClass.BlurBackground(new ProductAdd());
            GetData();
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                ProductAdd frm = new ProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);

                // frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCatID"].Value);
                //frm.txtPrice.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPrice"].Value);
                // frm.cbCat.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvCat"].Value);
                // frm.ShowDialog();
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
                    string qry = "DELETE FROM products WHERE pID = " + id;
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    GetData();

                    MessageBoxGunaOk.Show("Deleted Successfully ... ", "RMS", MessageBoxType.Succes);

                }


            }



        }

        public void GetData()
        {
            string qry = " select pID,pName,pPrice ,CategoryID,c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvCat);


            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

    }
}
