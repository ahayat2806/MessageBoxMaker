using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Box_Maker
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            var icon = MessageBoxIcon.Question; //default
            var buttonType = MessageBoxButtons.OK; //default
            string msg;
            string title;

            // get types

            msg = messageBox.Text;
            title = titleBox.Text;

            // convert

            switch (iconType.SelectedItem)
            {
                    case "Exclamation":
                    icon = MessageBoxIcon.Exclamation;
                    break;

                    case "Error":
                    icon = MessageBoxIcon.Error;
                    break;

                    case "Question":
                    icon = MessageBoxIcon.Question;
                    break;

                    case "Warning":
                    icon = MessageBoxIcon.Warning;
                    break;

                    case "Asterisk":
                    icon = MessageBoxIcon.Asterisk;
                    break;

                    case "Stop":
                    icon = MessageBoxIcon.Stop;
                    break;

                    case "Information":
                    icon = MessageBoxIcon.Information;
                    break;
            }

            switch (buttonPicker.SelectedItem)
            {
                    case "Ok":
                    buttonType = MessageBoxButtons.OK;
                    break;

                    case "Ok, Cancel":
                    buttonType = MessageBoxButtons.OKCancel;
                    break;

                    case "Retry, Cancel":
                    buttonType = MessageBoxButtons.RetryCancel;
                    break;

                    case "Yes, No, Cancel":
                    buttonType = MessageBoxButtons.YesNoCancel;
                    break;

                    case "Abort, Retry, Ignore":
                    buttonType = MessageBoxButtons.AbortRetryIgnore;
                    break;

                    case "Yes, No":
                    buttonType = MessageBoxButtons.YesNo;
                    break;
            }

            // Push Message

            MessageBox.Show(msg, title, buttonType, icon);

        }
    }
}
