using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
namespace App_13
{
    public partial class Default : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["HRcon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["data"] == null)
            {

                using (OracleConnection con = new OracleConnection(constr))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter("select * from emp", con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Cache["data"] = dt;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        Label1.Text = "Data Fetched from Database and Stored in Cache";
                    }
                }
            }
            else
            {
                GridView1.DataSource = Cache["data"];
                GridView1.DataBind();
                Label1.Text = "Data Fetched from Cache";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Cache.Remove("data");
            Label1.Text = "Data Deleted from Cache";

        }
    }
}