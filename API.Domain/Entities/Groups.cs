using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class Groups
    {
        [Key]
        public int Id { get; set; }
        public char Group {  get; set; }

        [ForeignKey("ChampionShip")]
        public int ChampionShipId { get; set; }
        public ChampionShips ChampionShip { get; set; }
    }
}
