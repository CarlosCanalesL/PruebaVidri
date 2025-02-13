using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaVidri.Entities
{
    public class Power
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Hero")]
        public int HeroId { get; set; }
        [StringLength(50)]
        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; }
    }
}
