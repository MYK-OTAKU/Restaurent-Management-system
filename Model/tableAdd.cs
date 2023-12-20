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
    public partial class tableAdd : SampleAdd
    {
        public tableAdd()
        {
            InitializeComponent();
        }

        private void tableAdd_Load(object sender, EventArgs e)
        {

        }
        public int id = 0;
        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//Insert 
            {
                qry = " Insert into tables Values (@Name)";
            }
            else // update
            {
                qry = " Update tables Set tname =  @Name where tid = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                //MessageBox.Show("Saved Successfully ... ");
                MessageBoxSuccess.Show("Saved Successfully ... ", " ", MessageBoxType.Succes);

                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }

        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
