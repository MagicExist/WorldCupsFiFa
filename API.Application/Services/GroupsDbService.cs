using API.Application.DTOs.GetGroupsByChampionShipDtos;
using API.Domain.Entities;
using API.Domain.Repository;

namespace API.Application.Services
{
    public class GroupsDbService
    {
        private readonly IGroupsDbRepository _groupsDbRepository;
        public GroupsDbService(IGroupsDbRepository groupsDbRepository) 
        {
            _groupsDbRepository = groupsDbRepository;
        }

        public async Task<GetGroupsByChampionShipDTO[]> GetGroupsByChampionShipAsync(int championShipId)
        {
            var dataRaw = await _groupsDbRepository.GetGroupsByChampionShipAsync(championShipId);
            var dataResult = dataRaw.Select(item => new GetGroupsByChampionShipDTO
            {
                GroupId = item.Id,
                ChampionShipId = item.ChampionShip.Id,
                ChampionShipName = item.ChampionShip.ChampionShip,
                CountryId = item.ChampionShip.Country.Id,
                CountryName = item.ChampionShip.Country.Country,
                CountryEntity = item.ChampionShip.Country.Entity
            }
            ).ToArray();
            return dataResult;
        }
    }
}
