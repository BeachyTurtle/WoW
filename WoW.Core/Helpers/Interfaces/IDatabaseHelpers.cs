using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace WoW.Core.Helpers
{
    public interface IDatabaseHelpers
    {        
        IDbConnection DbConnection { get; }
        Task<int> ExecuteStoredProcedureAsync(string storedProcedureName, object parameters);
        Task<IEnumerable<T>> FromStoredProcedureAsync<T>(string storedProcedureName);
        Task<IEnumerable<T>> FromStoredProcedureAsync<T>(string storedProcedureName, object parameters);
    }
}