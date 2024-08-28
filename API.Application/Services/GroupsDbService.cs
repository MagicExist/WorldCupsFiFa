
using API.Application.DTOs;
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

        public async Task<IEnumerable<GetGroupsByChampionShipDTO>> GetGroupsByChampionShip(int championShipId)
        {
            var dataResult = await _groupsDbRepository.GetGroupsByChampionShipAsync<GetGroupsByChampionShipDTO>(championShipId);
            return dataResult;
        }
    }
}
