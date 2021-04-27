using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW.Core.Helpers;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly IDatabaseHelpers _databaseHelpers;
        public CharacterRepository(IDatabaseHelpers databaseHelpers)
        {
            _databaseHelpers = databaseHelpers;
        }

        // Get Single Character by Id
        public async Task<Character> GetCharacterByUId(Guid uId)
        {
            var character = await _databaseHelpers.FromStoredProcedureAsync<Character>("dbo.usp_Character_GetByUId", new { UId = uId });
            return character.FirstOrDefault();
        }

        // Get Character By Name
        public async Task<Character> GetCharacterByName(string name)
        {
            var character = await _databaseHelpers.FromStoredProcedureAsync<Character>("dbo.usp_Character_GetByName", new { Name = name });
            return character.FirstOrDefault();
            
        }

        // Get All Characters by a Id
        public async Task<List<Character>> List()
        {
            var characters = await _databaseHelpers.FromStoredProcedureAsync<Character>("dbo.usp_Character_GetAll");
            return characters.ToList();
        }

        // Single method for inserting or updating a Character
        public Character Upsert(Character character)
        {
            throw new NotImplementedException();
        }

        // Delete a single character by it's Guid 
        public void Delete(Guid uId)
        {
            throw new NotImplementedException();
        }
    }
}
