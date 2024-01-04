using Restaurant_Management_System;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MessageBoxOK : Form
    {
        public MessageBoxOK()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return this.titleLbl.Text;
            }

            set
            {
                this.titleLbl.Text = value;
            }
        }

        public string Message
        {
            get
            {
                return this.messageLbl.Text;
            }

            set
            {
                this.messageLbl.Text = value;
            }
        }
        public MessageBoxType Type
        {
            set
            {
                switch (value)
                {
                    case MessageBoxType.INFO:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.info;
                        break;
                    case MessageBoxType.WARNING:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.warning;
                        break;
                    case MessageBoxType.ERROR:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.error;
                        break;
                    case MessageBoxType.Succes:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_verified_100;
                        break;
                    case MessageBoxType.OK:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_danger_96;
                        break;
                    case MessageBoxType.GunaOk:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_info_96;
                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(29, 161, 241);
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.FromArgb(136, 152, 166);
        }

        /// <summary>
        /// Show message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="button"></param>
        /// <returns></returns>
        public static DialogResult Show(string message, string title, MessageBoxType type = MessageBoxType.INFO)
        {
            DialogResult result = DialogResult.None;

            using (MessageBoxOK ok = new MessageBoxOK())
            {
                ok.Title = title;
                ok.Message = message;
                ok.Type = type;

                result = ok.ShowDialog();
            }

            return result;
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void typePicBox_Click(object sender, EventArgs e)
        {

        }

        private void messageLbl_Click(object sender, EventArgs e)
        {

        }

        private void footerPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLbl_Click(object sender, EventArgs e)
        {

        }

        private void bodyPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {

        }
    }
}
