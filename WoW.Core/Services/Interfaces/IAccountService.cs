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
        Task<Account> CheckExistsEmail(string email);
        Task<Account> CheckExistsDisplayName(string displayname);
        Task<Account> Register(string displayname, string password, string email);
        Task<Account> GetAccountByEmail(string email);
    }
}
