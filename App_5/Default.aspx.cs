using System;
using System.Data;

namespace App_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds=new DataSet();
                String path= Server.MapPath("~/Products.xml");
                ds.ReadXml(path);

                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, " -- Select Product -- ");

            }
        }

    }
}