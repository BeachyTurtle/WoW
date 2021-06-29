﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public interface IClassRepository
    {
        Task<List<Class>> PopulateClassComboBoxFromDatabaseForHorde();
        Task<List<Class>> PopulateClassComboBoxFromDatabaseForAlliance();
        Task<List<ClassRace>> GetAllClassRaceCombos();
        Task<List<Class>> GetClasses();
    }
}