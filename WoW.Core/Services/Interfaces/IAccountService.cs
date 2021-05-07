using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public interface IAccountService
    {
        Task Delete(Guid uId);
        Task<Account> Upsert(Account account);
        Task<Account> GetAccountByUId(Guid uId);
        Task<Account> Authenticate(string email, string password);
        Task<Account> CheckExists(string displayname, string email);
    }
}
