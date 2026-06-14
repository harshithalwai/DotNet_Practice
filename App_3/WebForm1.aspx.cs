using System;
using System.Diagnostics;

namespace App_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Class-level fields reset to 0 on every single request.
        int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            // This runs on EVERY load (both fresh GET requests and Redirect GET requests)
            if (Session["count"] != null)
            {
                count = (int)Session["count"];
            }
            else
            {
                count = 0;
            }

            // Always update the label so the user sees the current session value
            Label1.Text = "Count: " + count.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1. Get current value from session
            if (Session["count"] != null)
            {
                count = (int)Session["count"];
            }

            // 2. Increment it
            count++;

            // 3. Save it back to session
            Session["count"] = count;
            Debug.Write(count);

            // 4. Force the browser to switch from POST to GET
            Response.Redirect(Request.Url.ToString());
        }
    }
}