using System;
using System.Web.UI.WebControls;

namespace App_1
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                num1.Focus();
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);
            double result = 0;
            switch (btn.ID)
            {
                case "add":
                    result = n1 + n2;
                    break;
                case "sub":
                    result = n1 - n2;
                    break;
                case "mul":
                    result = n1 * n2;
                    break;
                case "div":
                    result = n1 / n2;
                    break;
            }
            res.Text = result.ToString();
        }

    }
}