using MyMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyMessageBox;
using Restaurant_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using System.Windows.Forms;

namespace Restaurant_Management_System.Forms
{
    public partial class MessageBoxSuccess : Form
    {
        public MessageBoxSuccess()
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
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_danger_96;
                        break;
                    case MessageBoxType.ERROR:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.error;
                        break;
                    case MessageBoxType.Succes:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_verified_check_circle_for_approved_valid_content_96;
                        break;
                    case MessageBoxType.OK:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_danger_96;
                        break;
                }
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageLbl_Click(object sender, EventArgs e)
        {

        } /// <summary>
          /// Show message
          /// </summary>
          /// <param name="message"></param>
          /// <param name="title"></param>
          /// <param name="button"></param>
          /// <returns></returns>
        public static DialogResult Show(string message, string title, MessageBoxType type = MessageBoxType.INFO)
        {
            DialogResult result = DialogResult.None;

            using (MessageBoxSuccess Succes = new MessageBoxSuccess())
            {
                Succes.Title = title;
                Succes.Message = message;
                Succes.Type = type;

                result = Succes.ShowDialog();
            }

            return result;
        }

    }
}
