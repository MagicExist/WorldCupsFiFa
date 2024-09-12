using API.Application.DTOs.GetGroupsByChampionShipDtos;
using API.Application.Services;
using API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace WorldCups_FiFa.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly GroupsDbService _groupsDbService;
        public GroupsController(GroupsDbService groupsDbService) 
        {
            _groupsDbService = groupsDbService;
        }

        [HttpGet("ChampionShips/{id}")]
        public async Task<GetGroupsByChampionShipDTO[]>  GetGroupsByChampionShipAsync(int id)
        {
            return await _groupsDbService.GetGroupsByChampionShipAsync(id);
        }
    }
}
