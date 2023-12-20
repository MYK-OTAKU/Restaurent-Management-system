using Restaurant_Management_System.Model;
using Restaurant_Management_System.View;
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
    public partial class pageprincipale : Form
    {
        public pageprincipale()
        {
            InitializeComponent();
        }
        private static pageprincipale _instance;

        public static pageprincipale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new pageprincipale(); // Ou initialisez de manière appropriée
                }
                return _instance;
            }
        }
        // Method to add controls in Main form
        //for assessing frm main 

        static pageprincipale _obj;

        //  public static object Instance { get; internal set; }

        public void AddControls(Form f)
        {


            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pageprincipale_Load(object sender, EventArgs e)
        {
            unamee.Text = MainClass.USER;
            _obj = this;

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void btncate_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryViews());

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void btntable_Click(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            AddControls(new StaffViews());

        }
    }
}
