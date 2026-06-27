// ============================================================================
// File Name : ExcelStreamReaderService.cs
//
// Purpose
// -------
// Reads Excel WITHOUT loading the complete file.
//
// This class is the heart of handling
// huge Excel files.
//
// Flow
//
// Open Excel
//
// ↓
//
// Skip Header
//
// ↓
//
// Read One Row
//
// ↓
//
// Store in Batch
//
// ↓
//
// Return Batch
//
// ============================================================================

using App_10.Helpers;
using App_10.Models;
using ExcelDataReader;
using System.Collections.Generic;
using System.IO;

namespace App_10.Services
{
    public class ExcelStreamReaderService
    {
        //----------------------------------------------------------
        // Batch Size
        //----------------------------------------------------------

        private const int BatchSize = 1000;

        //----------------------------------------------------------
        // Read Batch
        //----------------------------------------------------------

        public IEnumerable<BatchData> ReadBatches(
            string excelPath,
            string tableName,
            List<string> columns)
        {
            using (FileStream stream =
                File.Open(excelPath,
                FileMode.Open,
                FileAccess.Read))
            {
                using (IExcelDataReader reader =
                    ExcelReaderFactory.CreateReader(stream))
                {
                    // Skip Header
                    reader.Read();

                    BatchData batch =
                        new BatchData();

                    batch.TableName = tableName;

                    batch.Columns = columns;

                    while (reader.Read())
                    {
                        List<object> row =
                            new List<object>();

                        for (int i = 0;
                             i < reader.FieldCount;
                             i++)
                        {
                            row.Add(
                                DataTypeHelper.ConvertCell(
                                    reader.GetValue(i)));
                        }

                        batch.Rows.Add(row);

                        //--------------------------------------------------
                        // Return Every 1000 Rows
                        //--------------------------------------------------

                        if (batch.Rows.Count >= BatchSize)
                        {
                            yield return batch;

                            batch =
                                new BatchData();

                            batch.TableName = tableName;

                            batch.Columns = columns;
                        }
                    }

                    //------------------------------------------------------
                    // Remaining Rows
                    //------------------------------------------------------

                    if (batch.Rows.Count > 0)
                    {
                        yield return batch;
                    }
                }
            }
        }
    }
}