using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Core.Models
{
    public class Settings : ISettings
    {
        public Settings(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; set; }
    }
}
