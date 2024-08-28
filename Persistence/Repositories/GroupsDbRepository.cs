using API.Application.DTOs;
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
        public async Task<IEnumerable<Groups>> GetGroupsByChampionShipAsync(int championShipId)
        {
            IQueryable<Groups> query = from G in _dbCtx.Groups
                                                    join CS in _dbCtx.ChampionShips
                                                    on G.ChampionShipId equals CS.Id into G_CS
                                                    from CS in G_CS.DefaultIfEmpty()
                                                    join C in _dbCtx.Countries
                                                    on CS.CountryId equals C.Id into G_CS_C
                                                    from C in G_CS_C.DefaultIfEmpty() 
                                                    where CS.Id == championShipId
                                                    select new Groups
                                                    {
                                                        Id = G.Id,
                                                        Group = G.Group,
                                                        ChampionShip = new ChampionShips()
                                                        { 
                                                            Id = CS.Id,
                                                            ChampionShip = CS.ChampionShip,
                                                            Country = new Countries()
                                                            {
                                                                Id = C.Id,
                                                                Country = C.Country,
                                                                Entity = C.Entity
                                                            },
                                                            Year = CS.Year
                                                        }
                                                    };


            return await query.ToListAsync();
        }
    }
}
