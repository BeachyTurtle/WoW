using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class AccountLogin
    {
        public bool IsValidAccount { get; set; }
        public Guid UId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public bool IsAdmin { get; set; }
    }
}
