using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string City { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Countries Country { get; set; }
    }
}
