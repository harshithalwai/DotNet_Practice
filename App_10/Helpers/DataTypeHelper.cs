// ============================================================================
// File Name : DataTypeHelper.cs
//
// Purpose
// -------
// Converts Excel Cell Value into C# object.
//
// Initially we keep everything as string.
//
// Later this helper will detect:
//
// NUMBER
// DATE
// DECIMAL
// BOOLEAN
//
// ============================================================================

using System;

namespace App_10.Helpers
{
    public static class DataTypeHelper
    {
        //----------------------------------------------------------
        // Convert Excel Cell
        //----------------------------------------------------------

        public static object ConvertCell(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }

            string text = value.ToString().Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                return DBNull.Value;
            }

            return text;
        }
    }
}