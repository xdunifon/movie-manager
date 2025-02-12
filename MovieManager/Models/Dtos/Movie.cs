namespace MovieManager.Models.Dtos
{
    public class Movie
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateReleased { get; set; }

        public int GenreId { get; set; }
        public virtual required Genre Genre { get; set; }

        public int Duration { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
