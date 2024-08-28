using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Repository
{
    public interface IGroupsDbRepository
    {
        Task<Groups[]> GetGroupsByChampionShipAsync(int championShipId);
    }
}
