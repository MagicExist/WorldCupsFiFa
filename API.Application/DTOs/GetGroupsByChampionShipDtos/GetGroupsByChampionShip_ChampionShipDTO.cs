using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.DTOs.GetGroupsByChampionShipDtos
{
    public class GetGroupsByChampionShip_ChampionShipDTO
    {
        public int id { get; set; }
        public string? ChampionShip { get; set; }
        public GetGroupsByChampionShip_CountryDTO Country { get; set; }
        public int Year { get; set; }
    }
}
