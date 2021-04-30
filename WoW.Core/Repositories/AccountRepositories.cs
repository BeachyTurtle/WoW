using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public class AccountRepositories
    {
        public Account Authenticate(string email, string password)
        {
            // pass email and password to stored procedure
            // select from Account where email = email and password = password
            // if record found then update Account table, set LastLoginTime = DateTime.Now()
           
            throw new NotImplementedException();
        }

        public bool IsUserLoggedIn(Guid uId)
        {
            // We'll store the UserUId in a static class within the UI Project
            // When we need to check if the user is logged in, we will call this method
            // Call Repository method GetUserByUId
            // return IsLoggedIn boolean
            throw new NotImplementedException();
        }

        public Account GetByUId(Guid uId)
        {
            throw new NotImplementedException();
        }

        public Account Upsert(Account account)
        {
            // same as Character upsert
            throw new NotImplementedException();
        }

        public Account Delete(Account account)
        {
            // same as Character delete
            throw new NotImplementedException();
        }
    }
}
