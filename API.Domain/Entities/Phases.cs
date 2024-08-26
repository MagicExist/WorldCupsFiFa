using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Domain.Entities
{
    public class Phases
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Phase {  get; set; }
    }
}
