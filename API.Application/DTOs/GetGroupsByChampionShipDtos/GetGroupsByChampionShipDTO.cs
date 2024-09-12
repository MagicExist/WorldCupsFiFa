using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.DTOs.GetGroupsByChampionShipDtos
{
    public class GetGroupsByChampionShipDTO
    {
        public int GroupId { get; set; }
        public int ChampionShipId { get; set; }
        public string? ChampionShipName { get; set; }
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public string? CountryEntity { get; set; }
    }
}
