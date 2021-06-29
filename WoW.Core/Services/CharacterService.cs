using System;
using System.Collections.Generic;
using System.Text;
using WoW.Core.Models;
using WoW.Core.Repositories;
using System.Threading.Tasks;
using System.Linq;
using WoW.Core.Models.Enums;

namespace WoW.Core.Services
{
    public class CharacterService : ICharacterService
    {
        
        private readonly ICharacterRepository _characterRepository;
        private readonly ICharacterStatisticsRepository _characterStatisticsRepository;
        private readonly IClassRepository _classRepository;
        private readonly IRaceRepository _raceRepository;
        public CharacterService(ICharacterRepository characterRepository, 
            ICharacterStatisticsRepository characterStatisticsRepository, 
            IClassRepository classRepository,
            IRaceRepository raceRepository)
        {
            _characterRepository = characterRepository;
            _characterStatisticsRepository = characterStatisticsRepository;
            _classRepository = classRepository;
            _raceRepository = raceRepository;
        }

        public async Task<Character> GetCharacterByUId(Guid uId) => await _characterRepository.GetCharacterByUId(uId);

        public async Task<List<Character>> List() => await _characterRepository.List();

        public async Task<Character> GetCharacterByName(string name) => await _characterRepository.GetCharacterByName(name);

        public async Task<List<Character>> GetCharatersByGuild(Guid guild) => await _characterRepository.GetCharactersByGuild(guild);

        public async Task<List<Character>> GetCharactersByRace(int race) => await _characterRepository.GetCharactersByRace(race);

        public async Task<List<Character>> GetCharacterByClass(int characterClass) => await _characterRepository.GetCharacterByClass(characterClass);

        public async Task<Character> Upsert(Character character)
        {
            CharacterStatistics characterStatistics = new CharacterStatistics();
            BaseCharacterStats baseCharacterStats = new BaseCharacterStats();
            var characters = await _characterRepository.Upsert(character);
            characterStatistics = baseCharacterStats.SetBaseCharacterStats(characterStatistics);
            await _characterStatisticsRepository.CreateCharacterBaseStats(characterStatistics, characters.UId);
            characters.Statistics = characterStatistics;
            return characters;
        }
            

        public Task Delete(Guid uId) => _characterRepository.Delete(uId);

        public async Task<List<CharacterViewModel>> GetCharacterByAccountUid(Guid AccountUId)
        {
            var characters = await _characterRepository.GetCharacterByAccountUid(AccountUId);
            var classes = await _classRepository.GetClasses();
            var races = await _raceRepository.GetFormattedRaces();
            // Get a list of classes from class repository
            // Create a new class view model. Class = result of a linq query, select description from classes where Characterid = classid
            // Do the same for race
            var characterModel = characters.Select(x => new CharacterViewModel
            {
                UId = x.UId,
                Name = x.Name,
                Class = classes.Where(c => c.ClassId == x.Class).Select(c => c.Name).FirstOrDefault(),
                RaceName = races.Where(r => r.RaceId == x.Race).Select(r => r.RaceName).FirstOrDefault(),
                Level = x.Level,
                Gender = x.Gender.ToString(),
                Statistics = x.Statistics


            }) ;
            return characterModel.ToList();
        }


        
    }
}
