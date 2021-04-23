using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Core.Models
{
    public interface ISettings
    {
        string ConnectionString { get; set; }
    }
}
