namespace MovieManager.Models.ViewModels.Movies
{
    public class MovieTableRowVM
    {
        public int Id { get; set; }

        public int Duration { get; set; }

        public required string Genre { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string DateReleased { get; set; }
    }
}
