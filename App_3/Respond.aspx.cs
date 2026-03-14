using System;
using System.Web.UI.WebControls;

namespace App_3
{
    public partial class Respond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox username = (TextBox)PreviousPage.FindControl("txtUser");
                TextBox email = (TextBox)PreviousPage.FindControl("txtEmail");
                TextBox password = (TextBox)PreviousPage.FindControl("txtPass");

                RadioButton male = (RadioButton)PreviousPage.FindControl("male");
                RadioButton female = (RadioButton)PreviousPage.FindControl("felame");

                CheckBox A = (CheckBox)PreviousPage.FindControl("A");
                CheckBox B = (CheckBox)PreviousPage.FindControl("B");
                CheckBox C = (CheckBox)PreviousPage.FindControl("C");

                string title = "";

                if (male != null && male.Checked)
                    title = "Mr.";
                else if (female != null && female.Checked)
                    title = "Mrs.";

                string reports = "";

                if (A != null && A.Checked)
                    reports += "A ";

                if (B != null && B.Checked)
                    reports += "B ";

                if (C != null && C.Checked)
                    reports += "C ";

                Response.Write("<div style='font-family:Arial; padding:20px;'>");

                Response.Write("<h2 style='color:#4A6CF7;'>Hello " + title + " " + username.Text + "</h2>");
                Response.Write("<p>We have received your contact details.</p>");

                Response.Write("<hr/>");

                Response.Write("<p><b>Email:</b> " + email.Text + "</p>");
                Response.Write("<p><b>Password:</b> " + password.Text + "</p>");
                Response.Write("<p><b>Reports Selected:</b> " + reports + "</p>");

                Response.Write("</div>");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}
