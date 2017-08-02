using Exercise_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class LoginUserControl : Form
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (tbUserName.Text != "" && tbPass.Text != "")
            {
                Program.user.Username = tbUserName.Text;
                Program.user.Password = tbPass.Text;
                try
                {
                   
                    this.Hide();
                   LoggedInForm orderForm = new LoggedInForm();

                   
                   orderForm.preForm = this;

                    // Step 5 - Show the next form
                    orderForm.Show();
                }
                catch (Exception)
                {

                    throw;
                }

               
            }
            else
            {
                if (tbUserName.Text == "" && tbPass.Text != "")
                {
                    tbUserName.Focus();
                    MessageBox.Show("Please Enter Your User Name ");
                    // tbUserName.Focus();
                }
                else if (tbPass.Text == "" && tbUserName.Text != "")
                {
                    tbPass.Focus();
                    MessageBox.Show("Please Enter Password");
                    // tbUserName.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter User name and Password");
                }
            }
        }

        public static implicit operator UserControl(LoginUserControl v)
        {
            throw new NotImplementedException();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           tbUserName.Clear();
            tbPass.Clear();
           
            
        }

        private void LoginUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
