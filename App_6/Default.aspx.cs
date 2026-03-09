using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace App_6
{
    public partial class Default : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQualification();
            }
        }

        private void LoadQualification()
        {
            using (OracleConnection con = new OracleConnection(conStr))
            {
                con.Open();

                string query = "SELECT QUALIFICATIONCODE, QUALIFICATION FROM QUALIFICATION";

                OracleCommand cmd = new OracleCommand(query, con);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                ddlQualification.DataSource = dt;
                ddlQualification.DataTextField = "QUALIFICATION";
                ddlQualification.DataValueField = "QUALIFICATIONCODE";
                ddlQualification.DataBind();
            }
        }
    }
}