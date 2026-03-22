using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace App_11
{
    public partial class Default : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["HRcon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmployeeId.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(constr))
            {
                using (OracleCommand cmd = new OracleCommand("AddEmployee", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = txtFirstName.Text;
                    cmd.Parameters.Add("p_last_name", OracleDbType.Varchar2).Value = txtLastName.Text;
                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = txtEmail.Text;
                    cmd.Parameters.Add("p_phone_number", OracleDbType.Varchar2).Value = txtPhone.Text;

                    cmd.Parameters.Add("p_hire_date", OracleDbType.Date).Value =
                        Convert.ToDateTime(txtHireDate.Text);

                    cmd.Parameters.Add("p_job_id", OracleDbType.Varchar2).Value = txtJobId.Text;

                    // Salary
                    cmd.Parameters.Add("p_salary", OracleDbType.Decimal).Value =
                        string.IsNullOrWhiteSpace(txtSalary.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtSalary.Text);

                    // Commission
                    cmd.Parameters.Add("p_commission_pct", OracleDbType.Decimal).Value =
                        string.IsNullOrWhiteSpace(txtCommission.Text)
                        ? (object)DBNull.Value
                        : Convert.ToDecimal(txtCommission.Text);

                    // Manager ID
                    cmd.Parameters.Add("p_manager_id", OracleDbType.Int32).Value =
                        string.IsNullOrWhiteSpace(txtManagerId.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txtManagerId.Text);

                    // Department ID
                    cmd.Parameters.Add("p_department_id", OracleDbType.Int32).Value =
                        string.IsNullOrWhiteSpace(txtDepartmentId.Text)
                        ? (object)DBNull.Value
                        : Convert.ToInt32(txtDepartmentId.Text);

                    // OUT PARAMETER
                    OracleParameter pOut = new OracleParameter();
                    pOut.ParameterName = "p_employee_id";
                    pOut.OracleDbType = OracleDbType.Int32;
                    pOut.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(pOut);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    txtEmployeeId.Text = cmd.Parameters["p_employee_id"].Value.ToString();
                    lblMessage.Text = "Employee saved successfully";
                }
            }
        }
    }
}