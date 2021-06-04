using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public interface IClassService
    {
        Task<List<Class>> PopulateClassComboBoxFromDatabaseForHorde();
        Task<List<Class>> PopulateClassComboBoxFromDatabaseForAlliance();
        Task<List<ClassRace>> GetAllClassRaceCombos();
    }
}
