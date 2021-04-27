using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public interface ICharacterService
    {
        Task Delete(Guid uId);
        Task<Character> GetCharacterByName(string name);
        Task<List<Character>> List();
        Task<Character> GetCharacterByUId(Guid uId);
        Task<List<Character>> GetCharactersByRace(int race);
        Task<List<Character>> GetCharatersByGuild(Guid guild);
        Task<Character> Upsert(Character character);
        Task<List<Character>> GetCharacterByClass(int characterClass);
    }
}
