// ============================================================================
// File Name : ColumnNameHelper.cs
//
// Purpose
// -------
// Oracle has restrictions on column names.
//
// Example
// -------
// Employee Name
// Salary (₹)
// Date of Birth
// 123 Name
//
// Cannot be used directly.
//
// This helper converts every header into an Oracle Safe Column Name.
//
// Example
//
// Employee Name
//      ↓
// EMPLOYEE_NAME
//
// Salary (₹)
//      ↓
// SALARY
//
// 123 Name
//      ↓
// COL_123_NAME
//
// ============================================================================

using System.Text.RegularExpressions;

namespace App_10.Helpers
{
    public static class ColumnNameHelper
    {

        // Maximum Oracle Identifier Length
        private const int MAX_LENGTH = 30;

        public static string GetSafeColumnName(string columnName)
        {

            //----------------------------------------------------------
            // Null Check
            //----------------------------------------------------------

            if (string.IsNullOrWhiteSpace(columnName))
            {
                return "COLUMN";
            }


            //----------------------------------------------------------
            // Remove Starting and Ending Spaces
            //----------------------------------------------------------

            columnName = columnName.Trim();


            //----------------------------------------------------------
            // Convert to Upper Case
            //----------------------------------------------------------

            columnName = columnName.ToUpper();


            //----------------------------------------------------------
            // Replace Spaces with _
            //----------------------------------------------------------

            columnName = columnName.Replace(" ", "_");


            //----------------------------------------------------------
            // Remove Special Characters
            //----------------------------------------------------------

            columnName = Regex.Replace(columnName,
                                       @"[^A-Z0-9_]",
                                       "");


            //----------------------------------------------------------
            // Oracle does not allow identifier
            // starting with number.
            //----------------------------------------------------------

            if (char.IsDigit(columnName[0]))
            {
                columnName = "COL_" + columnName;
            }


            //----------------------------------------------------------
            // Oracle Identifier Maximum Length
            //----------------------------------------------------------

            if (columnName.Length > MAX_LENGTH)
            {
                columnName = columnName.Substring(0, MAX_LENGTH);
            }


            //----------------------------------------------------------
            // Empty Name
            //----------------------------------------------------------

            if (string.IsNullOrWhiteSpace(columnName))
            {
                columnName = "COLUMN";
            }

            return columnName;

        }

    }

}