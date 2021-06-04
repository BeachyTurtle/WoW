using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using WoW.Core.Models;

namespace WoW.Core.Repositories
{
    public interface ICharacterRepository
    {
        Task Delete(Guid uId);
        Task<Character> GetCharacterByName(string name);
        Task<Character> GetCharacterByUId(Guid uId);
        Task<List<Character>> List();
        Task<Character> Upsert(Character character);
        Task<List<Character>> GetCharactersByGuild(Guid guild);
        Task<List<Character>> GetCharactersByRace(int race);
        Task<List<Character>> GetCharacterByClass(int characterClass);
        Task<List<Character>> GetCharacterByAccountUid(Guid AccountUId);
    }
}