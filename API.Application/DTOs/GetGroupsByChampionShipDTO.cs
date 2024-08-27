using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.DTOs
{
    public class GetGroupsByChampionShipDTO
    {
        public int GroupId { get; set; }
        public char Group {  get; set; }
        public int ChampionShipId { get; set; }
        public string? ChampionShip {  get; set; }
        public int CountryId { get; set; }
        public string? Country { get; set; }
        public string? Entity { get; set; }
    }
}
