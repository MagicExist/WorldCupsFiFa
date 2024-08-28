using API.Domain.Entities;
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
        public ChampionShips? ChampionShips { get; set; }
        public Countries? Countries { get; set; }
    }
}
