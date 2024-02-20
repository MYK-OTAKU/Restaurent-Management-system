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
    public partial class StaffViews : sampleViews
    {
        public StaffViews()
        {
            InitializeComponent();
        }

        private void StaffViews_Load(object sender, EventArgs e)
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
            guna2DataGridView1.Columns["dgvPhone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvRole"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvedit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guna2DataGridView1.Columns["dgvdel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            guna2DataGridView1.Columns["dgvSno"].FillWeight = 0.5f;
            guna2DataGridView1.Columns["dgvid"].FillWeight = 1;
            guna2DataGridView1.Columns["dgvName"].FillWeight = 3.5F;
            guna2DataGridView1.Columns["dgvPhone"].FillWeight = 2;
            guna2DataGridView1.Columns["dgvRole"].FillWeight = 2;
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
            MainClass.BlurBackground(new StaffAdd());
            GetData();
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                StaffAdd frm = new StaffAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.cbRole.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvRole"].Value);
                // frm.ShowDialog();
                MainClass.BlurBackground(frm);

                GetData();
                //  MessageBoxSuccess.Show("Edition Successfully", "Edit");

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                // Affiche la boîte de dialogue
                if (MessageBoxGunaYesNo.Show("Êtes-vous sûr de vouloir supprimer cet employé(e) ?", "RMS", MessageBoxType.Question) == DialogResult.Yes)
                {
                    // Si le bouton "Yes" est pressé, effectue la suppression
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value); ;
                    string qry = "DELETE FROM staff WHERE staffID = " + id;
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);
                    GetData();

                    MainClass.Supp();  

                }


            }



        }
        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Vérifiez si la colonne actuelle est la colonne "dgvSno" et que la ligne n'est pas la ligne d'en-tête
            if (e.ColumnIndex == dgvSno.Index && e.RowIndex >= 0)
            {
                // Définissez la valeur de la cellule "dgvSno" comme le numéro de ligne + 1
                e.Value = e.RowIndex + 1;
            }
        }

        public void GetData()
        {
            string qry = " Select * From staff where sName like '%" + txtSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);


            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
