using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class CharacterViewModel
    {
        public Guid UId { get; set; }
        public string Name { get; set; }
        public string RaceName { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public CharacterStatistics Statistics { get; set; }

    }
}
