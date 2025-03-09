using System.ComponentModel.DataAnnotations;

namespace Filmbibliote.Modeller
{
    public class Film
    {
        public int FilmID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "The title can't exceed 100 characters.")]
        public required string Titel { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        public required string Genre { get; set; }

        [Range(1800, 2100, ErrorMessage = "Please enter a valid year.")]
        public int År { get; set; }

        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public double Betyg { get; set; }

        public string? UserID { get; set; }
    }
}

