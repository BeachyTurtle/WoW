using System;
using System.Collections.Generic;
using System.Text;
using WoW.Core.Models;
using WoW.Core.Repositories;
using System.Threading.Tasks;

namespace WoW.Core.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        public CharacterService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<Character> GetCharacterByUId(Guid uId)
        {
            return await _characterRepository.GetCharacterByUId(uId);
        }

        public async Task<List<Character>> List()
        {
            return await _characterRepository.List();
        }

        public async Task<Character> GetCharacterByName(string name)
        {
            return await _characterRepository.GetCharacterByName(name);
        }

        public async Task<List<Character>> GetCharatersByGuild(Guid uId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Character>> GetCharactersByRace(Guid uId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Character>> GetCharacterByClass(Guid uId)
        {
            throw new NotImplementedException();
        }

        public async Task<Character> Upsert(Character character)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid uId)
        {
            throw new NotImplementedException();
        }

       
    }
}
