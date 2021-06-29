using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class Item
    {
        public Guid UId { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public int SubCategory { get; set; }

    }
}
