using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
namespace App_10
{
    public partial class Default : System.Web.UI.Page
    {
        string conStr = ConfigurationManager.ConnectionStrings["HRcon"].ConnectionString;
        string query = "SELECT * FROM employees";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(conStr))
            {
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    con.Open();
                    using (OracleDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("ID");
                        table.Columns.Add("Name");
                        table.Columns.Add("Price");
                        table.Columns.Add("DiscountedPrice");

                        while (rdr.Read())
                        {
                            DataRow dataRow = table.NewRow();
                            int OriginalPrice = Convert.ToInt32(rdr["UnitPrice"]);
                            double DiscountedPrice = OriginalPrice * 0.9;

                            dataRow["ID"] = rdr["ProductId"];
                            dataRow["Name"] = rdr["ProductName"];
                            dataRow["Price"] = OriginalPrice;
                            dataRow["DiscountedPrice"] = DiscountedPrice;
                            table.Rows.Add(dataRow);
                        }
                        //GridView1.DataSource = rd;
                        //GridView1.DataBind();
                        GridView1.DataSource = table;
                        GridView1.DataBind();

                    }

                }
            }
        }
    }
}