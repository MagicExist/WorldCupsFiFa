using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class CountriesByGroups
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Groups Group { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Countries Country { get; set; }
    }
}
