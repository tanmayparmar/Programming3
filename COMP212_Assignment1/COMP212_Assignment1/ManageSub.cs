using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Assignment1
{
    public partial class ManageSub : Form
    {

        static string email = "";
        static string mobileNo = "";
        static bool email_Checked = false;
        static bool mobile_Checked = false;
        static bool isValidEmail = false;
        static bool isValidMobile = false;


        public ManagePublishForm publishFormOBJ = new ManagePublishForm();

        SendViaEmail sendToEmail;
        SendViaMobile sendToMobile;

        public ManageSub()
        {
            InitializeComponent();
        }

        private void ManageSub_Load(object sender, EventArgs e)
        {

        }

        private void sentByEmail_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = email_Checked = (checkboxEmail.Checked) ? true : false;
        }

        private void sentByPhone_CheckedChanged(object sender, EventArgs e)
        {
            txtPhone.Enabled = mobile_Checked = checkboxPhone.Checked ? true : false;
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            string message = "";
            sendEmailToMobile("Subscription");
            if (email_Checked && mobile_Checked)
            {
                if (isValidEmail && isValidMobile)
                {
                    sendToEmail = new SendViaEmail(email);
                    sendToEmail.Subscribe(publishFormOBJ);
                    sendToMobile = new SendViaMobile(mobileNo);
                    sendToMobile.Subscribe(publishFormOBJ);
                    message = "Your Subscription is successful";
                }
                else
                {
                    message = "Please check your email / Mobile";
                }

            }
            else if (email_Checked && !mobile_Checked)
            {
                if (isValidEmail)
                {
                    message = "Subscription successful";
                    sendToEmail = new SendViaEmail(email);
                    sendToEmail.Subscribe(publishFormOBJ);
                }
                else
                {
                    message = "Please check your email address";
                }
            }
            else if (mobile_Checked && !email_Checked)
            {
                if (isValidMobile)
                {
                    message = "Subscription successful!!!";
                    sendToMobile = new SendViaMobile(mobileNo);
                    sendToMobile.Subscribe(publishFormOBJ);
                }
                else
                {
                    message = "Please check your mobile number";
                }
            }
            MessageBox.Show(message);
        }

        private void btn_Unsubscribe_Click(object sender, EventArgs e)
        {
            sendEmailToMobile("Unsubscription");
            if (email_Checked && mobile_Checked)
            {
                if (isValidEmail && isValidMobile)
                {
                    MessageBox.Show("Unsubscription successful!!!");
                    sendToEmail = new SendViaEmail(email);
                    sendToEmail.Unsubscribe(publishFormOBJ);
                    sendToMobile = new SendViaMobile(mobileNo);
                    sendToMobile.Unsubscribe(publishFormOBJ);
                }
                else
                {
                    MessageBox.Show("Please check your email/mobile");
                }

            }
            else if (email_Checked && !mobile_Checked)
            {
                if (isValidEmail)
                {
                    sendToEmail = new SendViaEmail(email);
                    sendToEmail.Unsubscribe(publishFormOBJ);
                }
                else
                {
                    MessageBox.Show("Please check your email address");
                }
            }
            else if (mobile_Checked && !email_Checked)
            {
                if (isValidMobile)
                {
                    sendToMobile = new SendViaMobile(mobileNo);
                    sendToMobile.Unsubscribe(publishFormOBJ);
                }
                else
                {
                    MessageBox.Show("Please check your mobile number");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sendEmailToMobile(string subscribe)
        {
            if (email_Checked)
            {
                email = txtEmail.Text;
                isValidEmail = validateEmail(email);
            }
            if (mobile_Checked)
            {
                mobileNo = txtPhone.Text;
                isValidMobile = validateMobile(mobileNo);
            }
            if (!email_Checked && !mobile_Checked)
            {
                MessageBox.Show("Enter atleast an email or mobile number for " + subscribe);
            }
        }
        private bool validateEmail(string email)
        {

            try
            {
                var emadd = new System.Net.Mail.MailAddress(email);
                return emadd.Address == email;
            }
            catch (FormatException) { return false; }
        }

        private bool validateMobile(string mobile)
        {
            string pattern = @"\\D*([2-9]\\d{2})(\\D*)([2-9]\\d{2})(\\D*)(\\d{4})\\D*";
            if (Regex.IsMatch(mobile, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}






