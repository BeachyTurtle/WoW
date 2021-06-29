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
    public class ClassRepository : IClassRepository
    {
        private readonly IDatabaseHelpers _databaseHelpers;
        public ClassRepository(IDatabaseHelpers databaseHelpers)
        {
            _databaseHelpers = databaseHelpers;
        }

        public async Task<List<ClassRace>> GetAllClassRaceCombos()
        {
            var classes = await _databaseHelpers.FromStoredProcedureAsync<ClassRace>("usp_Class_GetAvailableClassesForRaces");
            return classes.ToList();
        }

        public async Task<List<Class>> GetClasses()
        {
            var classes = await _databaseHelpers.FromStoredProcedureAsync<Class>("dbo.usp_Class_GetFormattedClasses");
            return classes.ToList();
        }

        public async Task<List<Class>> PopulateClassComboBoxFromDatabaseForAlliance()
        {
            var classes = await _databaseHelpers.FromStoredProcedureAsync<Class>("dbo.usp_Class_GetAllClasses");
            return classes.ToList();
        }

        public async Task<List<Class>> PopulateClassComboBoxFromDatabaseForHorde()
        {
            var classes = await _databaseHelpers.FromStoredProcedureAsync<Class>("dbo.usp_Class_GetAllClasses");
            return classes.ToList();
        }
    }
}
