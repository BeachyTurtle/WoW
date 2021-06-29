using System;
using System.Collections.Generic;
using System.Text;
using WoW.Core.Models.Enums;

namespace WoW.Core.Models
{    public class Character
    {
        public Guid AccountUId { get; set; }
        // Character UId is a Guid, this is harder for any attackers to guess      
        public Guid UId { get; set; }
        public string Name { get; set; }
        // Set Faction to Enum
        public Faction Faction { get; set; }
        // Set Gender to Enum
        public Gender Gender { get; set; }
        // Race is a foreign key to a Race 'reference table', this means we can add new races without having to change code
        public int Race { get; set; }
        // Class is similar to race
        public int Class { get; set; }
        public int Level { get; set; }
        public double Playtime { get; set; }
        public Guid Guild { get; set; }
        public CharacterStatistics Statistics { get; set; }

        // public List<Item> EquippedItems
        // public List<Item> InventoryItems
        //Character equipment table and a character inventory table and those are link tables to the character
    }
}
