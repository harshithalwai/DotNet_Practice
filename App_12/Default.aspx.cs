using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Configuration;
namespace App_12
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["HRcon"].ConnectionString;

            using (OracleConnection con = new OracleConnection(CS))
            {
                OracleDataAdapter da = new OracleDataAdapter("spGetData", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.Add("p_products", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                da.SelectCommand.Parameters.Add("p_categories", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                DataSet ds = new DataSet();
                da.Fill(ds);

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

                GridView2.DataSource = ds.Tables[1];
                GridView2.DataBind();
            }
        }
    }
}