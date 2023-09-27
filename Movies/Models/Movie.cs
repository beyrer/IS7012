using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Movie Title")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "A Movie Title is Required")]
        public string Title { get; set; }

        [DisplayName("Director Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "A Director Name is Required")]
        public string? Director { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [DisplayName("Box Office")]
        [Range(1, 3000000000)]
        public decimal? BoxOffice { get; set; }
    }
}
