using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace API.Domain.Entities
{
    public class Stadiums
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Stadium { get; set; }
        [Range(0,int.MaxValue,ErrorMessage = "Value out of bounds")]
        public int Capacity { get; set; }
        [Url,StringLength(2048)]
        public string? Photo { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public Cities City { get; set; }
    }
}
