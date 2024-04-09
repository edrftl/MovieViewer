using MovieViewer.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace MovieViewer.Models
{
    public class FilmModel
    {
        public int Id { get; set; }

        [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
        public string Name { get; set; }

        [Range(1895, 2024)]
        public int Year { get; set; }

        [StringLength(4000, MinimumLength = 10)]
        public string Description { get; set; }

        [Range(0, 10)]
        public float Raiting { get; set; }

        [Range(0, int.MaxValue)]
        public int Likes { get; set; }

        [Range(0, int.MaxValue)]
        public int Dislikes { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }
    }
}
