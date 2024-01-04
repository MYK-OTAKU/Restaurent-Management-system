using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Forms
{
    public partial class MessageBoxGunaYesNo : Form
    {
        public int YesCount { get; private set; }
        public int NoCount { get; private set; }

        public MessageBoxGunaYesNo()
        {
            InitializeComponent();
        }

        private void MessageBoxGunaYesNo_Load(object sender, EventArgs e)
        {

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
                    case MessageBoxType.Question:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_question_100;
                        break;
                }
            }
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

            using (MessageBoxGunaYesNo ok = new MessageBoxGunaYesNo())
            {
                ok.Title = title;
                ok.Message = message;
                ok.Type = type;

                result = ok.ShowDialog();
            }

            return result;
        }
        private void titleLbl_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnYES_Click(object sender, EventArgs e)
        {

            this.Close();
            DialogResult = DialogResult.Yes;
            //  this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void messageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
