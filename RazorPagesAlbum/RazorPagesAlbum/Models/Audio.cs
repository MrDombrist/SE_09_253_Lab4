using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesAlbum.Models
{
    public class Audio
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }


        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Count { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Info { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Lenght { get; set; }

        [RegularExpression(@"^[0-9]")]
        public string Rating { get; set; } = string.Empty;
    }
}
