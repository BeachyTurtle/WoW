﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public interface IRaceRepository
    {
        Task<List<Race>> PopulateRaceComboBoxFromDatabase();
        Task<List<Race>> PopulateRaceComboBoxFromDatabaseHorde();
        Task<List<Race>> PopulateRaceComboBoxFromDatabaseAlliance();
        Task<List<Race>> GetFormattedRaces();
    }
}
