using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoW.API2.Models.RequestModels
{
    public class AuthenticationRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
