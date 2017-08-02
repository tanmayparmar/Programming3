using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment1
{
    public partial class ManagePublishForm : Form
    {
        List<string> emailList = new List<string>();
        List<string> mobileNoList = new List<string>();

        //Declare Delegate
        public delegate void PublishMessageDel();

        //Declare an instance variable which is a Delegate object 
        public static event PublishMessageDel publishmsg = null;

        public ManagePublishForm()
        {
            InitializeComponent();
            populateLists();
        }
        public void populateLists()
        {
            this.emailList = ManageNotification.emailList;
            this.mobileNoList = ManageNotification.mobileNoList;
        }
        private void btnPublish_Click(object sender, EventArgs e)
        {
            string message = txtMsg.Text;
            string text = "";
            message = message.Trim();
            if (message == "")
            {
                MessageBox.Show("Please type message to publish");
            }
            else
            {
                PublishMessage();
                text += "The message \"" + message + "\" has been sent to following: \n";
                text += "Email addresses: \n";
                foreach (var email in emailList)
                {
                    text += email + "\n";
                }
                text += "Mobile numbers: \n";
                foreach (var mobileNo in mobileNoList)
                {
                    text += mobileNo + "\n";
                }
                MessageBox.Show(text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    
    public void PublishMessage()
    {
        //Invoke Delegate
        publishmsg.Invoke();
    }
}
}
