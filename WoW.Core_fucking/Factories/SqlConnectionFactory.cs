using System;
using System.Data;
using System.Data.SqlClient;

namespace WoW.Core.Factories
{
    public static class SqlConnectionFactory
    {
        public static IDbConnection CreateConnection(string connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException("connectionString");

            return new SqlConnection(connectionString);
        }
    }
}
