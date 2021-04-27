using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public interface ICharacterRepository
    {
        void Delete(Guid uId);
        Task<Character> GetCharacterByName(string name);
        Task<Character> GetCharacterByUId(Guid uId);
        Task<List<Character>> List();
        Character Upsert(Character character);
    }
}