namespace MovieManager.Models.Database
{
    public class User
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public required string Name { get; set; }
        public DateTime DateBorn { get; set; }
    }
}
