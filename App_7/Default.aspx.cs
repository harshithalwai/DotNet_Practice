using System;

namespace App_7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblResult.Text =
                "<br>Name : " + txtName.Text +
                "<br>Password : " + txtPassword.Text +
                "<br>Address : " + txtAddress.Text +
                "<br>Mobile : " + txtMobile.Text +
                "<br>City : " + txtCity.Text +
                "<br>Email : " + txtEmail.Text +
                "<br>Age : " + txtAge.Text;
        }

        protected void txtCity_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = "City Changed to : " + txtCity.Text;
        }
    }
}