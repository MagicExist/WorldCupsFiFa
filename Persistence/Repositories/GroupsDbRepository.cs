using API.Domain.Entities;
using API.Domain.Repository;
using API.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence.Repositories
{
    internal class GroupsDbRepository : IGroupsDbRepository
    {
        private readonly WorldCupsDB _dbCtx; 
        public GroupsDbRepository(WorldCupsDB dbCtx) 
        {
            _dbCtx = dbCtx;
        }
        public async Task<IEnumerable<Groups>> GetGroupsByChampionShipAsync(int championShipId)
        {
            var query = from G in _dbCtx.Groups
                        join CS in _dbCtx.ChampionShips
                        on G.ChampionShipId equals CS.Id into G_CS
                        from CS in G_CS.DefaultIfEmpty()
                        join C in _dbCtx.Countries
                        on CS.CountryId equals C.Id into G_CS_C
                        from C in G_CS_C.DefaultIfEmpty() 
                        where CS.Id == championShipId
                        select new
                        {
                            Id = G.Id,
                            Group = G.Group,
                            ChampionShipId = G.ChampionShipId,
                            ChampionShip = G.ChampionShip.ChampionShip,
                            CountryId = C.Id,
                            Country = C.Country,
                            Entity = C.Entity
                        };


            return null;
        }
    }
}
