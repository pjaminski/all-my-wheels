using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace AllMyWheels.DAL
{
    public class DatabaseClient : IDatabaseClient
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;

        public DatabaseClient(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public IEnumerable<T> RunQuery<T>(string sql, object parameters)
        {
            return _connection.Query<T>(sql, parameters, _transaction);
        }

        public int RunCommand(string sql, object parameters)
        {
            return _connection.Execute(sql, parameters, _transaction);
        }

        public void BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = _connection.BeginTransaction(IsolationLevel.ReadCommitted);
            }
        }

        public void Commit()
        {
            try
            {
                _transaction?.Commit();
            }
            catch
            {
                _transaction?.Rollback();
                throw;
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void Rollback()
        {
            try
            {
                _transaction?.Rollback();
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _transaction?.Dispose();
                    _connection?.Dispose();

                    _transaction = null;
                    _connection = null;
                }
            }

            _disposed = true;
        }

        ~DatabaseClient()
        {
            Dispose(false);
        }
    }
}