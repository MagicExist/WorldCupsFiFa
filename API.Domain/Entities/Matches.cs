using API.Domain.Entities.CustomValidations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class Matches
    {
        [Key]
        public int Id { get; set; }
        [CustomValidation(typeof(DateMatchesValidation), nameof(DateMatchesValidation.ValidateEventDate))]
        public DateOnly? Date { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value out of bounds")]
        public int FirstCountryGoals { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Value out of bounds")]
        public int SecondCountryGoals { get; set; }

        [ForeignKey("FirstCountry")]
        public int FirstCountryId {get; set;}
        public Countries FirstCountry {get; set;}
        [ForeignKey("SecondCountry")]
        public int SecondCountryId { get; set; }
        public Countries SecondCountry { get; set; }
        [ForeignKey("Stadium")]
        public int StadiumId { get; set;}
        public Stadiums Stadium { get; set;}
        [ForeignKey("Phase")]
        public int PhaseId { get; set;}
        public Phases Phase { get; set;}
        [ForeignKey("ChampionShip")]
        public int ChampionShipId {  get; set;}
        public ChampionShips ChampionShip { get; set;}
    }
}
