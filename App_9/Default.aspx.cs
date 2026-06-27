//using Oracle.ManagedDataAccess.Client;
//using System;
//using System.Configuration;
//using System.Data;

//namespace App_9
//{
//    public partial class Default : System.Web.UI.Page
//    {
//        string ConString = ConfigurationManager.ConnectionStrings["SHcon"].ConnectionString;

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                using (OracleConnection con = new OracleConnection(ConString))
//                {
//                    con.Open();

//                    using (OracleCommand cmd = new OracleCommand())
//                    {
//                        cmd.CommandText = "SELECT CUST_ID, CUST_FIRST_NAME FROM CUSTOMERS";
//                        cmd.Connection = con;

//                        OracleDataAdapter da = new OracleDataAdapter(cmd);
//                        DataTable dt = new DataTable();
//                        da.Fill(dt);

//                        DropDownList1.DataSource = dt;
//                        DropDownList1.DataTextField = "CUST_FIRST_NAME";
//                        DropDownList1.DataValueField = "CUST_ID";
//                        DropDownList1.DataBind();
//                    }
//                }
//            }
//        }
//    }
//}










using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;

namespace App_9
{
    public partial class Default : System.Web.UI.Page
    {
        string ConString = ConfigurationManager.ConnectionStrings["SHcon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (OracleConnection con = new OracleConnection(ConString))
                {
                    con.Open();

                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT CUST_ID, CUST_FIRST_NAME FROM CUSTOMERS";

                        using (OracleDataReader dr = cmd.ExecuteReader())
                        {
                            DropDownList1.DataSource = dr;
                            DropDownList1.DataTextField = "CUST_FIRST_NAME";
                            DropDownList1.DataValueField = "CUST_ID";
                            DropDownList1.DataBind();
                        }
                    }
                }
            }
        }
    }
}