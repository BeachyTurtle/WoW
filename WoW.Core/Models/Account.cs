using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class Account
    {
        public Guid UId { get; set; }
        /// <summary>
        /// Email address is also the username
        /// </summary>
        public string Email { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// Account name
        /// </summary>
        public string DisplayName { get; set; }
        public DateTime LastLoginDateTime { get; set; }
        public bool IsLoggedIn { get { return LastLoginDateTime != null ? LastLoginDateTime > DateTime.Now.AddHours(-6) : false; } }
        public string Role { get; set; }
    }
}
