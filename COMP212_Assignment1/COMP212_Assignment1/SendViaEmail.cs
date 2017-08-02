using System.Windows.Forms;

namespace COMP212_Assignment1
{
    internal class SendViaEmail
    {
        private string email;

        ManagePublishForm managepublishFormOBJ = new ManagePublishForm();

        public SendViaEmail() { }
        public SendViaEmail(string email)
        {
            this.email = email;
        }




        public void setEmailAddr(string email)
        {
            this.email = email;
        }

        public string getEmailAddr()
        {
            return email;
        }

        public void addToEmailList()
        {
            ManageNotification.emailList.Add(this.email);
            MessageBox.Show(this.email);
        }
        public void removeFromEmailList()
        {
            ManageNotification.emailList.Remove(this.email);
            MessageBox.Show(this.email);
        }

        public void Subscribe(ManagePublishForm managepublishFormOBJ)
        {
            ManagePublishForm.publishmsg += addToEmailList;
        }

        public void Unsubscribe(ManagePublishForm managepublishFormOBJ)
        {
            ManagePublishForm.publishmsg += removeFromEmailList;
        }
    }
}
