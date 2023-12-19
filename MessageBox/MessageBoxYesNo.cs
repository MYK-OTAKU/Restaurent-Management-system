using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MessageBoxYesNo : Form
    {
        public MessageBoxYesNo()
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
                        this.typePicBox.Image = global::messagebox.Properties.Resources.info;
                        break;
                    case MessageBoxType.WARNING:
                        this.typePicBox.Image = global::messagebox.Properties.Resources.warning;
                        break;
                    case MessageBoxType.ERROR:
                        this.typePicBox.Image = global::messagebox.Properties.Resources.error;
                        break;
                    case MessageBoxType.OK:
                        this.typePicBox.Image = global::messagebox.Properties.Resources.icons8_danger_96;
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
            btnNo.BackColor = Color.FromArgb(29, 161, 241);
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.FromArgb(136, 152, 166);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.FromArgb(29, 161, 241);
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.FromArgb(136, 152, 166);
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

            using (MessageBoxYesNo yesNo = new MessageBoxYesNo())
            {
                yesNo.Title = title;
                yesNo.Message = message;
                result = yesNo.ShowDialog();
            }

            return result;
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
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

        private void typePicBox_Click(object sender, EventArgs e)
        {

        }

        private void messageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
