using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Whatever
{
    public class DbContext : IDisposable
    {
        private readonly IDbConnection _conn;
        public DbContext(string connString)
        {
            SqlMapper.PurgeQueryCache();

            _conn = new SqlConnection(connString);
            Connect();
        }

        public IDbConnection Connection
        {
            get
            {
                return _conn;
            }
        }

        public void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }

        public bool IsConnectionOpen
        {
            get
            {
                return _conn.State == ConnectionState.Open;
            }
        }

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
