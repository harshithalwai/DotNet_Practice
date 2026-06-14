//using System;
//using System.Diagnostics;

//namespace App_2
//{
//    public partial class WebForm1 : System.Web.UI.Page
//    {
//        static int count;
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                count = 0;
//                Label1.Text = "Count: " + count.ToString();
//            }
//        }

//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            count++;
//            Label1.Text = "Count: " + count.ToString();
//            Debug.Write(count);
//        }
//    }
//}

using System;
using System.Diagnostics;

namespace App_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                count = 0;
                Label1.Text = "Count: " + count.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["count"] != null)
            {
                count = (int)ViewState["count"];
            }
            count++;
            ViewState["count"] = count;
            Label1.Text = "Count: " + count.ToString();
            Debug.Write(count);
        }
    }
}