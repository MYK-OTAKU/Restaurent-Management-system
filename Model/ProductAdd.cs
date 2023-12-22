﻿using Restaurant_Management_System.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Model
{
    public partial class ProductAdd : SampleAdd
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id' , catName 'name' from category";
            MainClass.CBFill(qry, cbCat);
            if (cID > 0)
            {
                cbCat.SelectedValue = cID;
            }
            if (id > 0)
            {
                ForUpdateLoadDatat();
            }
        }
        public int id = 0;
        public int cID = 0;
        Byte[] imageByteArray;

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string filePath;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png , .jpeg)|* .png; *.jpg ; *jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                txtImage.Image = new Bitmap(filePath);
            }
        }
        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)//Insert 
            {
                qry = " Insert into products Values (@Name,@price,@cat,@img )";
            }
            else // update
            {
                qry = " Update products Set pName =  @Name ,pPrice = @price , CategoryID = @cat , pImage = @img where pID = @id";
            }
            //for image  
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            //ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                //MessageBox.Show("Saved Successfully ... ");
                MessageBoxSuccess.Show("Saved Successfully ... ", " ", MessageBoxType.Succes);

                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;

                cbCat.SelectedIndex = -1;
                txtName.Focus();
                txtImage.Image = Restaurant_Management_System.Properties.Resources.OIP__13_;

            }

        }
        private void ForUpdateLoadDatat()
        {
            string qry = @"  select * from products where pID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();
                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                Byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));

            }
        }

        public override void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
