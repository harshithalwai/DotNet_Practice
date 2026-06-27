// ============================================================================
// File Name : OracleTableService.cs
//
// Purpose
// -------
// Creates Oracle Table Dynamically.
//
// Input
//
// EMPLOYEE_ID
// NAME
// SALARY
//
// Output
//
// CREATE TABLE IMPORT_20260627
// (
//      EMPLOYEE_ID VARCHAR2(4000),
//      NAME VARCHAR2(4000),
//      SALARY VARCHAR2(4000)
// )
//
// ============================================================================

using App_10.DAL;
using System.Collections.Generic;
using System.Text;

namespace App_10.Services
{
    public class OracleTableService
    {
        //---------------------------------------------------------------------
        // Create Table
        //---------------------------------------------------------------------

        public void CreateTable(OracleRepository repository, string tableName, List<string> columns)
        {
            StringBuilder sql =
                new StringBuilder();

            sql.AppendLine($"CREATE TABLE {tableName}");

            sql.AppendLine("(");

            for (int i = 0; i < columns.Count; i++)
            {
                sql.Append($"    {columns[i]} VARCHAR2(4000)");

                if (i != columns.Count - 1)
                {
                    sql.Append(",");
                }

                sql.AppendLine();
            }

            sql.AppendLine(")");

            repository.ExecuteNonQuery(sql.ToString());
        }
    }
}