using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class ChampionShips
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string ChampionShip { get; set; }
        [Range(1930, 3000, ErrorMessage = "Value out of bounds")]
        public short Year { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Countries Country { get; set; }
    }
}
