using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Helpers;
using WoW.Core.Models;
using WoW.Core.Repositories;

namespace WoW.Core.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly IDatabaseHelpers _databaseHelpers;
        public RaceRepository (IDatabaseHelpers databaseHelpers)
        {
            _databaseHelpers = databaseHelpers;
        }

        public async Task<List<Race>> PopulateRaceComboBoxFromDatabase()
        {
            var races = await _databaseHelpers.FromStoredProcedureAsync<Race>("dbo.usp_Race_GetAllRaces");
            return races.ToList();
        }

        public async Task<List<Race>> PopulateRaceComboBoxFromDatabaseAlliance()
        {
            var races = await _databaseHelpers.FromStoredProcedureAsync<Race>("dbo.usp_Race_GetAllRaces");
            return races.ToList();
        }

        public async Task<List<Race>> PopulateRaceComboBoxFromDatabaseHorde()
        {
            var races = await _databaseHelpers.FromStoredProcedureAsync<Race>("dbo.usp_Race_GetAllRaces");
            return races.ToList();
        }
    }
}
