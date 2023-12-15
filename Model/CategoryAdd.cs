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

namespace Restaurant_Management_System
{
    public partial class CategoryAdd : SampleAdd
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int id = 0;
        public virtual void BtnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//Insert 
            {
                qry = " Isert into category Values (@Name)";
            }
            else // update
            {
                qry = " Update category Set CatName =  @Name wherre catID = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Saved Succesqfully ... ");
                id = 0;
                txtName.Focus();
            }

        }
    }
}
