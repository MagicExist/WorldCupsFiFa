using System.ComponentModel.DataAnnotations;
namespace API.Domain.Entities
{
    public class Countries
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(75)]
        public string Country { get; set; }
        [StringLength(100)]
        public string Entity {  get; set; }
        [Url,StringLength(2048)]
        public string? Flag { get; set; }
        [Url,StringLength(2048)]
        public string? EntityLogo { get; set; }
    }
}
