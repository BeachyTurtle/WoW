using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using WoW.Core.Repositories.Interfaces;
using WoW.Core.Services.Interfaces;

namespace WoW.Core.Services
{
    public class AccountServices : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountServices(IAccountRepository accountRepository)
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

        public Account Register(string email, string password, string characterName)
        {
            // email, password, maybe display name like Vozma, Effia etc?
            // map the properties to Account
            // call upsert method
            throw new NotImplementedException();
        }

        public async Task<Account> GetAccountByUId(Guid uId) => await _accountRepository.GetAccountByUId(uId);

        public async Task Delete(Guid uId) => await _accountRepository.Delete(uId);

        public async Task<Account> Upsert(Account account) => await _accountRepository.Upsert(account);
        
    }
}
