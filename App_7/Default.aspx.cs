using System;

namespace App_7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //one.Style["background-color"] = TextBox1.Text;
            one.Attributes.Add("style", "background :" + TextBox1.Text);
            //Response.Write("<script>alert('Hi My Name is " + TextBox1.Text + "!')</script>");
        }
    }
}