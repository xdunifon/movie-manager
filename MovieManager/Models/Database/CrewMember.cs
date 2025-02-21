namespace MovieManager.Models.Database
{
    public class CrewMember
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
    }
}
