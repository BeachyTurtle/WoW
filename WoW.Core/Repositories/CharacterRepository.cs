using System;
using System.Collections.Generic;
using System.Text;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public class CharacterRepository
    {
        // Get Single Character by Id
        public Character GetCharacterById(Guid uId)
        {
            throw new NotImplementedException();
        }

        // Get All Characters by a Id
        public Character List()
        {
            throw new NotImplementedException();
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
