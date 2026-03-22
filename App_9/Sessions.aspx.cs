using System;

namespace App_9
{
    public partial class Sessions : System.Web.UI.Page
    {
        int count = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["count"] = 0;
                Label1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Session["count"]);
            count++;

            Session["count"] = count;
            Label1.Text = count.ToString();
        }
    }
}