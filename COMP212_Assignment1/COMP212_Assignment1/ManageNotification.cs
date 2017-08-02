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
    public partial class ManageNotification : Form
    {

      public static  List<string> emailList = new List<string> ();
        public static List<string> mobileNoList = new List<string> ();


        public ManageNotification()
        {
            InitializeComponent();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            ManagePublishForm managePublishOBJ = new ManagePublishForm();
            managePublishOBJ.Show();
        }

        private void btnmanageSubscription_Click(object sender, EventArgs e)
        {
            emailList.Clear();
            mobileNoList.Clear();
            ManageSub subObj = new ManageSub();
            subObj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
