using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using WoW.Core.Repositories;
using WoW.Core.Services;

namespace WoW.Core.Services
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository _raceRepository;
        public RaceService(IRaceRepository raceRepository)
        {
            _raceRepository = raceRepository;
        }

        public async Task<List<Race>> PopulateComboBoxFromDatabase() => await _raceRepository.PopulateComboBoxFromDatabase();
        
    }
}
