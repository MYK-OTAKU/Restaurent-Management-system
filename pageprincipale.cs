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

        // Method to add controls in Main form

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

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }
    }
}
