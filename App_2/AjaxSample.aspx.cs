using System;

namespace App_2
{
    public partial class AjaxSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                num1.Focus();
            }
        }

        protected void btn_command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);
            double result = 0;
            switch (e.CommandName)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
            }
            res.Text = result.ToString();
        }
    }
}