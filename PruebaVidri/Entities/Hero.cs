using System.ComponentModel.DataAnnotations;

namespace PruebaVidri.Entities
{
    public class Hero
    {
        [Key]
        public int HeroId { get; set; }
        [Required]
        [StringLength(50)]
        public required string name { get; set; }
        public string? Alias { get; set; }
    }
}
