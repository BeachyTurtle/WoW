using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using static WoW.Core.Models.CharacterStatistics;

namespace WoW.Core.Models
{
    public class BaseCharacterStats
    {

        public CharacterStatistics SetBaseCharacterStats(CharacterStatistics characterStatistics)
        {
            characterStatistics.Strength = 10;
            characterStatistics.Intellect = 10;
            characterStatistics.Agility = 10;
            characterStatistics.Stamina = 10;
            characterStatistics.Crit = 5;
            characterStatistics.Haste = 5;
            characterStatistics.Mastery = 5;
            characterStatistics.Versatility = 5;
            characterStatistics.Avoidance = 0;
            characterStatistics.Leech = 0;
            return characterStatistics;
        }
    }
}
