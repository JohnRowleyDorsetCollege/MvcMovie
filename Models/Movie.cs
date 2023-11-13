using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.Date)]// annotation
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

        public string? Rating { get; set; }
    }
}
