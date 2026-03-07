using System;

namespace App_3
{
    public partial class Respond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = Request.Form["txtUser"];
            //string email = Request.Form["txtEmail"];
            //string password = Request.Form["txtPass"];

            string username = Request.QueryString["txtUser"];
            string email = Request.QueryString["txtEmail"];
            string password = Request.QueryString["txtPass"];

            if (!string.IsNullOrEmpty(username))
            {
                Response.Write("<div style='font-family:Arial; padding:20px;'>");

                Response.Write("<h2 style='color:#4A6CF7;'>Hello " + username + "</h2>");
                Response.Write("<p>We have received your contact details.</p>");

                Response.Write("<hr/>");

                Response.Write("<p><b>Email:</b> " + email + "</p>");
                Response.Write("<p><b>Password:</b> " + password + "</p>");

                Response.Write("</div>");
            }
            else
            {
                Response.Write("<h3>No form data received.</h3>");
            }
        }
    }
}