
using API.Application.DTOs;
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

        public async Task<IEnumerable<Groups>> GetGroupsByChampionShipAsync(int championShipId)
        {
            var dataResult = await _groupsDbRepository.GetGroupsByChampionShipAsync(championShipId);
            return dataResult;
        }
    }
}
