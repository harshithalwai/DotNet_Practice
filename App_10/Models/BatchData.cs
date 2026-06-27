// ============================================================================
// File Name : BatchData.cs
//
// Purpose
// -------
// Represents one batch of Excel rows.
//
// Example
//
// Batch Size = 1000
//
// Excel
//
// Row1
// Row2
// ...
// Row1000
//
// ↓
//
// BatchData
//
// ============================================================================

using System.Collections.Generic;

namespace App_10.Models
{
    public class BatchData
    {
        //----------------------------------------------------------
        // Table Name
        //----------------------------------------------------------

        public string TableName
        {
            get;
            set;
        }

        //----------------------------------------------------------
        // Oracle Column Names
        //----------------------------------------------------------

        public List<string> Columns
        {
            get;
            set;
        }

        //----------------------------------------------------------
        // Actual Row Data
        //
        // List<Row>
        //
        // Row = List<object>
        //----------------------------------------------------------

        public List<List<object>> Rows
        {
            get;
            set;
        }

        //----------------------------------------------------------
        // Constructor
        //----------------------------------------------------------

        public BatchData()
        {
            Columns = new List<string>();

            Rows = new List<List<object>>();
        }
    }
}