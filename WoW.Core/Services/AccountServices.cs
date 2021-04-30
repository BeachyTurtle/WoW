using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public class AccountServices
    {
        public Account Authenticate(string email, string password)
        {
            // call Authenticate repository method, pass in email and password, return Account
            throw new NotImplementedException();
        }

        public Account Register(string email, string password, string characterName)
        {
            // email, password, maybe display name like Vozma, Effia etc?
            // map the properties to Account
            // call upsert method
            throw new NotImplementedException();
        }

        public Account GetByUId(Guid uId)
        {            
            throw new NotImplementedException();
        }

        public Account Delete(Guid UId)
        {
            throw new NotImplementedException();
        }
    }
}
