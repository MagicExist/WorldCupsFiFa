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

        public async Task<GetGroupsByChampionShip_GroupDTO[]> GetGroupsByChampionShipAsync(int championShipId)
        {
            var dataRaw = await _groupsDbRepository.GetGroupsByChampionShipAsync(championShipId);
            var dataResult = dataRaw.Select(item => new GetGroupsByChampionShip_GroupDTO
            {
                Id = item.Id,
                Group = item.Group,
                ChampionShips = new GetGroupsByChampionShip_ChampionShipDTO 
                {
                    id = item.ChampionShip.Id,
                    ChampionShip = item.ChampionShip.ChampionShip,
                    Year = item.ChampionShip.Year,
                    Country = new GetGroupsByChampionShip_CountryDTO
                    {
                        id = item.ChampionShip.Country.Id,
                        Country = item.ChampionShip.Country.Country,
                        Entity = item.ChampionShip.Country.Entity
                    }
                }
            }
            ).ToArray();
            return dataResult;
        }
    }
}
