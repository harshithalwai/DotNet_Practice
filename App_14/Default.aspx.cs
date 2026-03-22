using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace App_14
{
    public partial class Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["HRcon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(cs))
            {
                string sqlQuery = "SELECT * FROM Students WHERE ID = :ID";

                OracleDataAdapter da = new OracleDataAdapter(sqlQuery, con);
                da.SelectCommand.Parameters.Add(":ID", OracleDbType.Int32).Value = Convert.ToInt32(txtStudentID.Text);

                DataSet ds = new DataSet();
                da.Fill(ds, "Students");

                ViewState["SQL_QUERY"] = sqlQuery;
                ViewState["DATASET"] = ds;

                if (ds.Tables["Students"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Students"].Rows[0];

                    txtStudentName.Text = dr["NAME"].ToString();
                    txtTotalMarks.Text = dr["MARKS"].ToString();
                    ddlGender.SelectedValue = dr["GENDER"].ToString();
                    lblStatus.Text = "";
                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "No Student record with ID = " + txtStudentID.Text;
                }
            }
        }

        // UPDATE BUTTON
        protected void Button2_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(cs))
            {
                OracleDataAdapter da = new OracleDataAdapter((string)ViewState["SQL_QUERY"], con);

                OracleCommandBuilder builder = new OracleCommandBuilder(da);

                DataSet ds = (DataSet)ViewState["DATASET"];

                if (ds.Tables["Students"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Students"].Rows[0];

                    dr["NAME"] = txtStudentName.Text;
                    dr["GENDER"] = ddlGender.SelectedValue;
                    dr["MARKS"] = txtTotalMarks.Text;
                }

                da.Update(ds, "Students");

                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Record Updated Successfully";
            }
        }
        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    using (OracleConnection con = new OracleConnection(cs))
        //    {
        //        string query = @"UPDATE Students 
        //                         SET NAME = :Name,
        //                             GENDER = :Gender,
        //                             TOTALMARKS = :Marks
        //                         WHERE ID = :ID";

        //        OracleCommand cmd = new OracleCommand(query, con);

        //        cmd.Parameters.Add(":Name", txtStudentName.Text);
        //        cmd.Parameters.Add(":Gender", ddlGender.SelectedValue);
        //        cmd.Parameters.Add(":Marks", txtTotalMarks.Text);
        //        cmd.Parameters.Add(":ID", txtStudentID.Text);

        //        con.Open();
        //        int rows = cmd.ExecuteNonQuery();

        //        if (rows > 0)
        //        {
        //            lblStatus.ForeColor = System.Drawing.Color.Green;
        //            lblStatus.Text = "Record Updated Successfully";
        //        }
        //        else
        //        {
        //            lblStatus.ForeColor = System.Drawing.Color.Red;
        //            lblStatus.Text = "Update Failed";
        //        }
        //    }
        //}
    }
}