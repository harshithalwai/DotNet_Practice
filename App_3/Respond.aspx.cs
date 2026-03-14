using System;
using System.Web.UI.WebControls;

namespace App_3
{
    public partial class Respond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////For this method you need to set the form method to POST in Login.aspx

            //string username = Request.Form["txtUser"];
            //string email = Request.Form["txtEmail"];
            //string password = Request.Form["txtPass"];

            ////for this method you need to set the form method to GET in Login.aspx

            //string username = Request.QueryString["txtUser"];
            //string email = Request.QueryString["txtEmail"];
            //string password = Request.QueryString["txtPass"];



            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox username = (TextBox)PreviousPage.FindControl("txtUser");
                TextBox email = (TextBox)PreviousPage.FindControl("txtEmail");
                TextBox password = (TextBox)PreviousPage.FindControl("txtPass");

                Response.Write("<div style='font-family:Arial; padding:20px;'>");

                Response.Write("<h2 style='color:#4A6CF7;'>Hello " + username.Text + "</h2>");
                Response.Write("<p>We have received your contact details.</p>");

                Response.Write("<hr/>");

                Response.Write("<p><b>Email:</b> " + email.Text + "</p>");
                Response.Write("<p><b>Password:</b> " + password.Text + "</p>");

                Response.Write("</div>");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}