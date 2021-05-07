using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Helpers;
using WoW.Core.Models;
using WoW.Core.Repositories;
using WoW;

namespace WoW.Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        
        private readonly IDatabaseHelpers _databaseHelpers;
        public AccountRepository(IDatabaseHelpers databaseHelpers)
        {
            _databaseHelpers = databaseHelpers;
        }
        public async Task<Account> Authenticate(string email, string password)
        {
            // pass email and password to stored procedure
            // select from Account where email = email and password = password
            // if record found then update Account table, set LastLoginTime = DateTime.Now()

            var account = await _databaseHelpers.FromStoredProcedureAsync<Account>("dbo.usp_Account_Authenticate", new { email = email, password = password });
            return account.FirstOrDefault();

        }

        public bool IsUserLoggedIn(Guid uId)
        {
            // We'll store the UserUId in a static class within the UI Project
            // When we need to check if the user is logged in, we will call this method
            // Call Repository method GetUserByUId
            // return IsLoggedIn boolean
            throw new NotImplementedException();
        }

        // same as get Character by uId
        public async Task<Account> GetAccountByUId(Guid uId)
        {
            var account = await _databaseHelpers.FromStoredProcedureAsync<Account>("dbo.usp_Account_GetByUId", new { accountUId = uId });
            return account.FirstOrDefault();
        }

        // same as Character delete
        public async Task Delete(Guid uId) => await _databaseHelpers.ExecuteStoredProcedureAsync("dbo.usp_Account_Delete", new { accountUId = uId });

        // same as Character upsert
        public async Task<Account> Upsert(Account account)
        {
            var accounts = await _databaseHelpers.FromStoredProcedureAsync<Account>("dbo.usp_Account_Upsert", new { accountuId = account.UId, email = account.Email, password = account.Password, displayname = account.DisplayName, lastlogindatetime = account.LastLoginDate, isloggedin = account.IsLoggedIn, role = account.Role  });
            return (Account)accounts;
        }

        public async Task<Account> CheckExists(string displayname, string email)
        {
            
            var account = await _databaseHelpers.FromStoredProcedureAsync<Account>("dbo.usp_Account_CheckExists", new { displayname = displayname, email = email });
            return account.FirstOrDefault();
        }
    }
}
