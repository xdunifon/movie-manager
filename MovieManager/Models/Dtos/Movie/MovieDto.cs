using MovieManager.Models.Database;

namespace MovieManager.Models.Dtos.Movie
{
    public class MovieDto
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateReleased { get; set; }

        public int GenreId { get; set; }
        public int Duration { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
