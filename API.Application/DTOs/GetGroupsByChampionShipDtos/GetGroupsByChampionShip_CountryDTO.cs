using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.DTOs.GetGroupsByChampionShipDtos
{
    public class GetGroupsByChampionShip_CountryDTO
    {
        public int id { get; set; }
        public string? Country { get; set; }
        public string? Entity { get; set; }
    }
}
