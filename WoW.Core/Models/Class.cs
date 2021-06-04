using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public bool IsHorde { get; set; }
        public bool IsAlliance { get; set; }
    }
}
