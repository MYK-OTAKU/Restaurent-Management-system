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
    public partial class Checkout : SampleAdd
    {
        public Checkout()
        {
            InitializeComponent();
        }
        public double amt;
        public int MainID;
        private void Checkout_Load(object sender, EventArgs e)
        {
             txtBillAmount.Text = amt.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;
           
            double.TryParse(txtBillAmount.Text , out amt);
            double.TryParse(txtReceived.Text , out receipt);
          //  double.TryParse(txtChange.Text ,out change);
            change = Math.Abs(amt - receipt);

            txtChange.Text = change.ToString();
        }
        public override void BtnSave_Click(object sender, EventArgs e)
        {
            string qry = @"Update tblMain Set  total = @total ,received = @rec ,
                                               change = @change, status = 'Paid' 
                                               where MainID  = @id ";
            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if(MainClass.SQL(qry,ht) > 0 )
            {
                MessageBoxGunaOk.Show("Paiement effectué avec succes Success ... ", "RMS", MessageBoxType.Succes);
                this.Close();
            }



        }
    }
}
