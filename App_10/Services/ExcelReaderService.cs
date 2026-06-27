// ============================================================================
// File Name : ExcelReaderService.cs
//
// Purpose
// -------
// This Service is responsible ONLY for reading Excel.
//
// It DOES NOT:
//
// Create Oracle Table
//
// Insert Data
//
// Execute SQL
//
// It ONLY:
//
// Read Header
//
// Return Oracle Safe Column Names
//
// ============================================================================

using App_10.Helpers;
using ExcelDataReader;
using System.Collections.Generic;
using System.IO;

namespace App_10.Services
{

    public class ExcelReaderService
    {

        //==============================================================
        // Get Column Names
        //
        // Reads ONLY first row.
        //
        // Returns Oracle Safe Column List.
        //==============================================================

        public List<string> GetColumnNames(string excelPath)
        {

            //----------------------------------------------------------
            // Final Column List
            //----------------------------------------------------------

            List<string> columns =
                new List<string>();


            //----------------------------------------------------------
            // Open Excel File
            //----------------------------------------------------------

            using (FileStream stream =
                File.Open(excelPath,
                          FileMode.Open,
                          FileAccess.Read))
            {

                //------------------------------------------------------
                // Create Excel Reader
                //------------------------------------------------------

                using (IExcelDataReader reader =
                    ExcelReaderFactory.CreateReader(stream))
                {

                    //--------------------------------------------------
                    // Read First Row Only
                    //--------------------------------------------------

                    if (reader.Read())
                    {

                        //--------------------------------------------------
                        // Loop through every column
                        //--------------------------------------------------

                        for (int i = 0;
                             i < reader.FieldCount;
                             i++)
                        {

                            //--------------------------------------------------
                            // Read Header
                            //--------------------------------------------------

                            string header =
                                reader.GetValue(i)?
                                .ToString();


                            //--------------------------------------------------
                            // Convert to Oracle Safe Name
                            //--------------------------------------------------

                            string safeName =
                                ColumnNameHelper
                                .GetSafeColumnName(header);


                            //--------------------------------------------------
                            // Add into List
                            //--------------------------------------------------

                            columns.Add(safeName);

                        }

                    }

                }

            }

            //----------------------------------------------------------
            // Return Final List
            //----------------------------------------------------------

            return columns;

        }

    }

}