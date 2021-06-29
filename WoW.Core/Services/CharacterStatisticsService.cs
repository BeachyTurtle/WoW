using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Helpers;
using WoW.Core.Models;
using WoW.Core.Repositories;

namespace WoW.Core.Services
{
    public class CharacterStatisticsService : ICharacterStatisticsService
    {
        private readonly ICharacterStatisticsRepository _characterStatisticsRepository;

        public CharacterStatisticsService(ICharacterStatisticsRepository characterStatisticsRepository)
        {
            _characterStatisticsRepository = characterStatisticsRepository;
        }

        public async Task CreateCharacterBaseStats(CharacterStatistics characterStatistics, Guid guid)
            => await _characterStatisticsRepository.CreateCharacterBaseStats(characterStatistics, guid); 
            
       
    }
}
