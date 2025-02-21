using MovieManager.Models.Database;

namespace MovieManager.Models.Dtos.Movie
{
    public class MovieDisplayDto
    {
        public int Id { get; set; }
        public int Duration { get; set; }

        public required string DateReleased { get; set; }
        public required string Genre { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
