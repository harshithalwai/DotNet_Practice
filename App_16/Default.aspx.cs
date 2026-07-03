using System;
using System.Web.UI.WebControls;

namespace App_14
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {

            if (e.NextStepIndex == 2)
            {

                lblFirstName.Text = txtFirstName.Text;
                lblLastName.Text = txtLastName.Text;
                lblGender.Text = ddlGender.SelectedValue;

                lblMobile.Text = txtMobile.Text;
                lblEmail.Text = txtEmail.Text;
            }
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


