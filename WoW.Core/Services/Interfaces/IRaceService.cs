using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public interface IRaceService
    {
        Task<List<Race>> PopulateComboBoxFromDatabase();
    }
}
