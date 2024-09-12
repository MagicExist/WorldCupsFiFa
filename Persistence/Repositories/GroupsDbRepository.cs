using API.Application.DTOs;
using API.Application.DTOs.GetGroupsByChampionShipDtos;
using API.Domain.Entities;
using API.Domain.Repository;
using API.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Repositories
{
    public class GroupsDbRepository : IGroupsDbRepository
    {
        private readonly WorldCupsDB _dbCtx; 
        public GroupsDbRepository(WorldCupsDB dbCtx) 
        {
            _dbCtx = dbCtx;
        }
        public async Task<Groups[]> GetGroupsByChampionShipAsync(int championShipId)
        {
            IQueryable<Groups>   query = _dbCtx.Groups
                                                    .Include(group => group.ChampionShip)
                                                    .ThenInclude(championShip => championShip.Country)
                                                    .Where(group => group.ChampionShip.Id == championShipId)
                                                    .Select(group => new Groups
                                                    {
                                                        Id = group.Id,
                                                        ChampionShip = new ChampionShips
                                                        {
                                                            Id = group.ChampionShip.Id,
                                                            ChampionShip = group.ChampionShip.ChampionShip,
                                                            Country = new Countries
                                                            {
                                                                Id = group.ChampionShip.Country.Id,
                                                                Country = group.ChampionShip.Country.Country,
                                                                Entity = group.ChampionShip.Country.Entity
                                                            }
                                                        }
                                                        
                                                    });
                                        


            return await query.ToArrayAsync();
        }
    }
}
