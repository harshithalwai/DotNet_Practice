// ============================================================================
// File Name : ImportService.cs
//
// Purpose
// -------
// This class controls the complete Import Process.
//
// Flow
//
// Upload
//     ↓
// Read Header
//     ↓
// Generate Oracle Columns
//     ↓
// Create Oracle Table
//     ↓
// (Later)
// Read Data
//     ↓
// Batch Insert
//
// ============================================================================

using App_10.DAL;
using App_10.Models;
using System;
using System.Collections.Generic;

namespace App_10.Services
{
    public class ImportService
    {
        //---------------------------------------------------------------------
        // Excel Reader Service
        //---------------------------------------------------------------------

        private readonly ExcelReaderService excelService;

        //---------------------------------------------------------------------
        // Oracle Table Service
        //---------------------------------------------------------------------

        private readonly OracleTableService tableService;

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        public ImportService()
        {
            excelService = new ExcelReaderService();

            tableService = new OracleTableService();
        }

        //---------------------------------------------------------------------
        // Start Import
        //---------------------------------------------------------------------

        public ImportResult StartImport(string excelPath)
        {
            ImportResult result =
                new ImportResult();

            OracleRepository repository =
                new OracleRepository();

            try
            {
                //--------------------------------------------------------------
                // Open Oracle Connection
                //--------------------------------------------------------------

                repository.Open();

                //--------------------------------------------------------------
                // Start Transaction
                //--------------------------------------------------------------

                repository.BeginTransaction();

                //--------------------------------------------------------------
                // Read Header
                //--------------------------------------------------------------

                List<string> columns =
                    excelService.GetColumnNames(excelPath);

                //--------------------------------------------------------------
                // Generate Dynamic Table Name
                //--------------------------------------------------------------

                string tableName =
                    "IMPORT_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss");

                //--------------------------------------------------------------
                // Create Oracle Table
                //--------------------------------------------------------------

                tableService.CreateTable(
                    repository,
                    tableName,
                    columns);

                //--------------------------------------------------------------
                // Commit Transaction
                //--------------------------------------------------------------

                repository.Commit();

                //--------------------------------------------------------------
                // Return Success
                //--------------------------------------------------------------

                result.IsSuccess = true;

                result.Message =
                    "Oracle Table Created Successfully.";

                result.TableName =
                    tableName;
            }
            catch (Exception ex)
            {
                repository.Rollback();

                result.IsSuccess = false;

                result.Message = ex.Message;
            }
            finally
            {
                repository.Dispose();
            }

            return result;
        }
    }
}