using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectRegisteration
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     

        }
        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            //call a method to send email
            mailMgr myMail = new mailMgr();
            myMail.myFrom = txtFrom.Text;
            myMail.myTo = txtTo.Text;
            myMail.mySubject = txtSubject.Text;
            myMail.myBody = txtMessage.Text;
            lblOutput.Text = myMail.sendEmailViaGmail();
            // lblOutput.Text = myMsg;


        }
    }
}