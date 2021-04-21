using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Core.Models
{    public class Character
    {
        public Guid UId { get; set; }
        public string Name { get; set; }
        public string Faction { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public double Playtime { get; set; }
        public string Guild { get; set; }
        public string Class { get; set; }
        public CharacterStatistics Statistics { get; set; }
    }
}
