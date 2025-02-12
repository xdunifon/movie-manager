namespace MovieManager.Models.Dtos
{
    public class Review
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public required string Subject { get; set; }
        public required string Content { get; set; }
        public int Rating { get; set; } // out of 5
        public int MovieId { get; set; }
        public int UserId { get; set; }
    }
}
