// ============================================================================
// File Name : OracleRepository.cs
//
// Purpose
// -------
// This class is responsible for communicating with Oracle Database.
//
// IMPORTANT
// ---------
// This is the ONLY class where OracleConnection,
// OracleCommand,
// OracleTransaction
// should exist.
//
// Business Layer should NEVER directly access Oracle.
//
// ============================================================================

using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace App_10.DAL
{
    public class OracleRepository : System.IDisposable
    {
        //---------------------------------------------------------------------
        // Connection String
        //---------------------------------------------------------------------

        private readonly string connectionString =
            ConfigurationManager
            .ConnectionStrings["ConStr"]
            .ConnectionString;

        //---------------------------------------------------------------------
        // Oracle Connection Object
        //---------------------------------------------------------------------

        private OracleConnection connection;

        //---------------------------------------------------------------------
        // Oracle Transaction
        //---------------------------------------------------------------------

        private OracleTransaction transaction;

        //---------------------------------------------------------------------
        // Constructor
        //---------------------------------------------------------------------

        public OracleRepository()
        {
            connection = new OracleConnection(connectionString);
        }

        //---------------------------------------------------------------------
        // Open Connection
        //---------------------------------------------------------------------

        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        //---------------------------------------------------------------------
        // Close Connection
        //---------------------------------------------------------------------

        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        //---------------------------------------------------------------------
        // Begin Transaction
        //---------------------------------------------------------------------

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        //---------------------------------------------------------------------
        // Commit
        //---------------------------------------------------------------------

        public void Commit()
        {
            transaction?.Commit();
        }

        //---------------------------------------------------------------------
        // Rollback
        //---------------------------------------------------------------------

        public void Rollback()
        {
            transaction?.Rollback();
        }

        //---------------------------------------------------------------------
        // Execute SQL
        //---------------------------------------------------------------------

        public void ExecuteNonQuery(string sql)
        {
            using (OracleCommand cmd =
                new OracleCommand(sql, connection))
            {
                cmd.Transaction = transaction;

                cmd.ExecuteNonQuery();
            }
        }

        //---------------------------------------------------------------------
        // Dispose
        //---------------------------------------------------------------------

        public void Dispose()
        {
            Close();

            connection.Dispose();
        }
    }
}