using System;
using System.Collections.Generic;
using System.Text;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public class CharacterServices
    {
        public Character GetCharacterById(Guid uId)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetCharatersByGuild(Guid uId)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetCharactersByRace(Guid uId)
        {
            throw new NotImplementedException();
        }
        public List<Character> GetCharacterByClass(Guid uId)
        {
            throw new NotImplementedException();
        }

        public Character Upsert(Character character)
        {
            throw new NotImplementedException();
        }

       public void Delete(Guid uId)
        {
            throw new NotImplementedException();
        }
    }
}
