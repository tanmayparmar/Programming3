using System.Windows.Forms;

namespace COMP212_Assignment1
{
    internal class SendViaMobile
    {
 
     

        private string phoneNo;

        public SendViaMobile() { }

        public SendViaMobile(string phone)
        {
            phoneNo = phone;
        }

        public void setMobile(string phone)
        {
            phoneNo = phone;
        }

        public string getMobile()
        {
            return phoneNo;
        }

        public void addToMobileList()
        {
            ManageNotification.mobileNoList.Add(this.phoneNo);
            MessageBox.Show(this.phoneNo);
        }
        public void removeFromMobileList()
        {
            ManageNotification.emailList.Remove(this.phoneNo);
            MessageBox.Show(this.phoneNo);
        }

        public void Subscribe(ManagePublishForm managepublishFormOBJ)
        {
            ManagePublishForm.publishmsg += addToMobileList;
        }

        public void Unsubscribe(ManagePublishForm managepublishFormOBJ)
        {
            ManagePublishForm.publishmsg += removeFromMobileList;
        }
    }
}
