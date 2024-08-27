using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Repository
{
    internal interface IChampionShipDbRepository
    {
        Task<IEnumerable<Groups>> GetGroupsByChampionShipAsync(int championShipId);
    }
}
