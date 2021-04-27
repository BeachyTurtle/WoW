using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WoW.Core.Models;

namespace WoW.Core.Services
{
    public interface ICharacterService
    {
        Task Delete(Guid uId);
        Task<Character> GetCharacterByName(string Name);
        Task<List<Character>> GetCharacterByClass(Guid uId);
        Task<List<Character>> List();
        Task<Character> GetCharacterByUId(Guid uId);
        Task<List<Character>> GetCharactersByRace(Guid uId);
        Task<List<Character>> GetCharatersByGuild(Guid uId);
        Task<Character> Upsert(Character character);
    }
}
