using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.DTOs.GetGroupsByChampionShipDtos
{
    public class GetGroupsByChampionShip_GroupDTO
    {
        public int Id { get; set; }
        public char Group { get; set; }
        public GetGroupsByChampionShip_ChampionShipDTO? ChampionShips { get; set; }
    }
}
