namespace MovieManager.Models.Database
{
    public class MovieToPlaylist
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PlaylistId { get; set; }
    }
}
