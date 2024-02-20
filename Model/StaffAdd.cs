using Restaurant_Management_System.Forms;
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

namespace Restaurant_Management_System.Model
{
    public partial class StaffAdd : SampleAdd
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        private void StaffAdd_Load(object sender, EventArgs e)
        {

        }
        public int id = 0;
        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//Insert 
            {
                qry = " Insert into staff Values (@Name,@phone,@role)";
            }
            else // update
            {
                qry = " Update staff Set sName =  @Name ,sPhone = @phone , sRole = @role where staffID = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                int rowsAffected = MainClass.SQL(qry, ht);

                if (rowsAffected > 0)
                {
                    if (id == 0)
                    {
                        MainClass.Enres();
                    }
                    else
                    {
                        MainClass.Modif();

                    }

                    
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();

                }

            }

        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {

        }
    }
}
