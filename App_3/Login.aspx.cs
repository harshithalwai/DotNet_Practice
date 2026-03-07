using System;

namespace App_3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUser.Focus();
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtEmail.Text = txtPass.Text = string.Empty;
            txtUser.Focus();
        }
    }
}