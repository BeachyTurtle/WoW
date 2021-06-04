using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Core.Models
{
    public class ClassRace
    {
        public int ClassRaceId { get; set; }
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public string ClassName  { get; set; }
    }
}
