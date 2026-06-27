using System;
using System.Data;

namespace App_10
{
    public partial class Defaultaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string phyPath = Server.MapPath("sample.xml");
            ds.ReadXml(phyPath);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}