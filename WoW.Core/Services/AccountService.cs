using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using WoW.Core.Repositories;
using WoW.Core.Services;

namespace WoW.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<Account> Authenticate(string email, string password)
        {
            // call Authenticate repository method, pass in email and password, return Account
            var account =  await _accountRepository.Authenticate(email, password);
            if (account != null)
            {
                return account;
            }
            else
            {
                // Display message box with you aren't logged in
                return account;
            }
      
        }

        // email, password, maybe display name like Vozma, Effia etc?
        // map the properties to Account
        // call upsert method
        public async Task<Account> Register(string displayName, string password, string email) => await _accountRepository.Register(displayName, password, email);
      
        public async Task<Account> GetAccountByUId(Guid uId) => await _accountRepository.GetAccountByUId(uId);

        public async Task Delete(Guid uId) => await _accountRepository.Delete(uId);

        public async Task<Account> Upsert(Account account) => await _accountRepository.Upsert(account);

        public async Task<Account> CheckExistsEmail(string email) => await _accountRepository.CheckExistsEmail(email);

        public async Task<Account> CheckExistsDisplayName(string displayname) => await _accountRepository.CheckExistsDisplayName(displayname);

    }
}
