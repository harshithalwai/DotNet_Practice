using System;
using System.Data;
using System.Web.UI.WebControls;

namespace App_7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DataSet ds = new DataSet();
                String PhysicalPath = Server.MapPath("~/Products.xml");
                ds.ReadXml(PhysicalPath);

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, " -- Select Product -- ");

                ListBox1.DataSource = ds;
                ListBox1.DataTextField = "Name";
                ListBox1.DataValueField = "Id";
                ListBox1.DataBind();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //one.Style["background-color"] = TextBox1.Text;
            one.Attributes.Add("style", "background :" + TextBox1.Text);
            //Response.Write("<script>alert('Hi My Name is " + TextBox1.Text + "!')</script>");
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label1.Text = "";
            foreach (int i in ListBox1.GetSelectedIndices())
            {

                ListItem li = ListBox1.Items[i]; Label1.Text += li.Value + ": " + li.Text + "<br />";
            }
        }
    }
}