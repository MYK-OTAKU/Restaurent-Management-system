using System;
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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public string OrderType = "";
        public string CusName = "";
        public int MainID = 0;
        public int DriverID = 0;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (OrderType == "Take Away")
            {
                lblDriver.Visible = false; 
                cbDriver.Visible = false; 
            }
            string qry = "select staffID 'id' , sName 'name'  from staff where sRole =  'Driver'";
            MainClass.CBFill(qry, cbDriver);
            if (MainID>0)
            {
                cbDriver.SelectedValue = DriverID;
            }

        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriverID = Convert.ToInt32(cbDriver.SelectedValue) ;
        }
    }
}
