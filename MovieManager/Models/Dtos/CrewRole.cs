namespace MovieManager.Models.Dtos
{
    public class CrewRole
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public required string Name { get; set; }
    }
}
