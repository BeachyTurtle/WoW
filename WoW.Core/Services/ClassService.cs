using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;
using WoW.Core.Repositories;

namespace WoW.Core.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository raceRepository)
        {
            _classRepository = raceRepository;
        }

        public async Task<List<ClassRace>> GetAllClassRaceCombos() => await _classRepository.GetAllClassRaceCombos();

        public async Task<List<Class>> PopulateClassComboBoxFromDatabaseForAlliance()
        {
            var comboBoxData = await _classRepository.PopulateClassComboBoxFromDatabaseForAlliance();
            var comboBoxDataAlliance = comboBoxData.Where(alliance => alliance.IsAlliance == true);
            return comboBoxDataAlliance.ToList();
        }

        public async Task<List<Class>> PopulateClassComboBoxFromDatabaseForHorde()
        {
            var comboBoxData = await _classRepository.PopulateClassComboBoxFromDatabaseForHorde();
            var comboBoxDataHorde = comboBoxData.Where(horde => horde.IsHorde == true);
            return comboBoxDataHorde.ToList();
        }
        
    }
}
