using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Helpers;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public class CharacterStatisticsRepository : ICharacterStatisticsRepository
    {
        private readonly IDatabaseHelpers _databaseHelpers;

        public CharacterStatisticsRepository(IDatabaseHelpers databaseHelpers)
        {
            _databaseHelpers = databaseHelpers;
        }

        public async Task CreateCharacterBaseStats(CharacterStatistics characterStatistics, Guid guid)
        {
            var characterStats = await _databaseHelpers.ExecuteStoredProcedureAsync
                ("[dbo].[usp_CharacterStatistics_SetBaseCharacterStatistics]", 
                new
                {
                    characterUId = guid,
                    characterStatistics.Intellect,
                    characterStatistics.Agility,
                    characterStatistics.Strength,
                    characterStatistics.Stamina,
                    characterStatistics.Crit,
                    characterStatistics.Haste,
                    characterStatistics.Mastery,
                    characterStatistics.Versatility,
                    characterStatistics.Avoidance,
                    characterStatistics.Leech
                });
            
        }
            
            


    }
}
