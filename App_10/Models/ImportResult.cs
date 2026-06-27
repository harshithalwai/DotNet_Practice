// ============================================================================
// File Name : ImportResult.cs
//
// Purpose
// -------
// Every Service should return one common object.
//
// Instead of returning
//
// true
//
// false
//
// We return complete information.
//
// Example
//
// Success
//
// Error Message
//
// Table Name
//
// Total Rows
//
// Imported Rows
//
// Failed Rows
//
// ============================================================================

namespace App_10.Models
{

    public class ImportResult
    {

        //----------------------------------------------------------
        // Import Success
        //----------------------------------------------------------

        public bool IsSuccess
        {
            get;
            set;
        }


        //----------------------------------------------------------
        // User Friendly Message
        //----------------------------------------------------------

        public string Message
        {
            get;
            set;
        }


        //----------------------------------------------------------
        // Dynamic Oracle Table Name
        //----------------------------------------------------------

        public string TableName
        {
            get;
            set;
        }


        //----------------------------------------------------------
        // Total Rows Found
        //----------------------------------------------------------

        public int TotalRows
        {
            get;
            set;
        }


        //----------------------------------------------------------
        // Successfully Imported
        //----------------------------------------------------------

        public int ImportedRows
        {
            get;
            set;
        }


        //----------------------------------------------------------
        // Failed Rows
        //----------------------------------------------------------

        public int FailedRows
        {
            get;
            set;
        }

    }

}