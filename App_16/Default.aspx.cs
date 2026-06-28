using System;
using System.Web.UI.WebControls;

namespace App_14
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            lblMessage.Text =
                "Registration Successful!<br /><br />" +
                "Name : " + txtName.Text + "<br />" +
                "Age : " + txtAge.Text + "<br />" +
                "Email : " + txtEmail.Text + "<br />" +
                "Phone : " + txtPhone.Text;
        }
    }
}


