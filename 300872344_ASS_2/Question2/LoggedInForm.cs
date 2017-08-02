using Question2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class LoggedInForm : Form
    {
        public LoginUserControl preForm;

        public LoggedInForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            
            this.preForm.Show();

              this.Close();
         
        }

        private void LoggedInForm_Load(object sender, EventArgs e)
        {
            
            this.lblUserName.Text = "You are logged in as "+Program.user.Username;
            this.lblPass.Text = "With the password: " + Program.user.Password;
        }

       
    }
}
