using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using WoW.Core.Factories;

namespace WoW.Core.Helpers
{
    public class DapperHelpers : IDatabaseHelpers
    {
        private readonly ISettings _settings;
        public DapperHelpers(ISettings settings)
        {
            _settings = settings;
        }        

        public IDbConnection DbConnection { get => SqlConnectionFactory.CreateConnection(_settings.ConnectionString); }

        public async Task<IEnumerable<T>> FromStoredProcedureAsync<T>(string storedProcedureName)
        {
            using (DbConnection)
            {
                return await DbConnection.QueryAsync<T>(storedProcedureName);
            }
        }

        public async Task<IEnumerable<T>> FromStoredProcedureAsync<T>(string storedProcedureName, object parameters)
        {
            using (DbConnection)
            {
                return await DbConnection.QueryAsync<T>(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> ExecuteStoredProcedureAsync(string storedProcedureName, object parameters)
        {
            using (DbConnection)
            {
                return await DbConnection.ExecuteAsync(storedProcedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
