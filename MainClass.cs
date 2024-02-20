using Restaurant_Management_System.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Restaurant_Management_System
{
    internal class MainClass
    {
        public bool result = false;



        public static readonly string con_string = "Data Source=DESKTOP-TIPN3BA\\MSSQLSERVER02;Initial Catalog=Projetdegroupe;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(con_string);
        //Method to check user validation 

        public static bool IsValidUser(string user, string pass)

        {
            bool isValid = false;

            string qry = " select* from users  where username = '" + user + "' and upass = '" + pass + "' ";


            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();
            }





            return isValid;
        }






        //adding blue effect
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;

                // Définir la taille maximale sur la taille maximisée de la page principale
                Background.MaximumSize = pageprincipale.Instance.Size;

                // Utiliser la taille maximale par défaut si elle est disponible, sinon une taille par défaut
                Size defaultSize = Background.MaximumSize = new Size(2400, 2400);

                Background.Size = defaultSize;
                Console.WriteLine($"Taille de Background : {Background.Size}");  // Ligne de débogage
                Background.Location = pageprincipale.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }















        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;


            try
            {

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)

                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value); ; ; ; ; ; ; ; ; ; ; ;
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                con.Close();

            }

            return res;
        }
        // For loading data from database 

        public static void LoadData(String qry, DataGridView gv, ListBox lb)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }


    
    public static void Enres()
        {
           
            MessageBoxGunaOk.Show("Enregistré avec succès ... ", " ", MessageBoxType.Succes);
            
        } public static void Modif()
        {
           
            MessageBoxGunaOk.Show("Modifié avec succès ... ", " ", MessageBoxType.Succes);

        }
        public static void Supp()
        {

            MessageBoxGunaOk.Show("Supprimé avec succès ... ", " ", MessageBoxType.Succes); ;

        } public static void QSupp()
        {
            if(MessageBoxGunaYesNo.Show("Are you sure you want to delete", "RMS", MessageBoxType.Question) == DialogResult.Yes);
            

        }
        public static void MC(string Message)
        {

        } 
        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }





        }
        // for cb fill
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";

            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

    }






}
