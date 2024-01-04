using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Guna.UI2.WinForms;

using System.Data;
using MyMessageBox;
using Restaurant_Management_System.Forms;

namespace Restaurant_Management_System
{
    public partial class Login : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Login()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {  // ON va creer la base de donné et la table 
            if (MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                MessageBoxGunaOk.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxType.OK);

                // MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                pageprincipale pgp = new pageprincipale();
                pgp.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}
