using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Core.Models
{
    public class CharacterStatistics
    {
            public Guid UId { get; set; }
            public int Intellect { get; set; }
            public int Agility { get; set; }
            public int Strength { get; set; }
            public int Stamina { get; set; }
            public int Crit { get; set; }
            public int Haste { get; set; }
            public int Mastery { get; set; }
            public int Versatility { get; set; }
            public int Avoidance { get; set; }
            public int Leech { get; set; }
    }
}
