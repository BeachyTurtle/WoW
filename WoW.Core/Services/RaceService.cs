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

        public async Task<List<Race>> PopulateComboBoxFromDatabase() => await _raceRepository.PopulateRaceComboBoxFromDatabase();

        public async Task<List<Race>> PopulateRaceComboBoxFromDatabaseAlliance()
        {
            var comboBoxData = await _raceRepository.PopulateRaceComboBoxFromDatabaseAlliance();
            var comboBoxDataAlliance = comboBoxData.Where(alliance => alliance.FactionId == 1);
            return comboBoxDataAlliance.ToList();
        }

        public async Task<List<Race>> PopulateRaceComboBoxFromDatabaseHorde()
        {
            var comboBoxData = await _raceRepository.PopulateRaceComboBoxFromDatabaseHorde();
            var comboBoxDataHorde = comboBoxData.Where(horde => horde.FactionId == 0);
            return comboBoxDataHorde.ToList();
        }
    }

    /*public async Task<List<Class>> PopulateClassComboBoxFromDatabaseForAlliance()
    {
        var comboBoxData = await _classRepository.PopulateClassComboBoxFromDatabaseForAlliance();
        var comboBoxDataAlliance = comboBoxData.Where(alliance => alliance.IsAlliance == true);
        return comboBoxDataAlliance.ToList();
    }*/
}
