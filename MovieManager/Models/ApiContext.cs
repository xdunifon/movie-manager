using Microsoft.EntityFrameworkCore;
using MovieManager.Models.Database;

namespace MovieManager.Models
{
    public class ApiContext : DbContext
    {
        public string DbPath { get; set; }

        public ApiContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Path.Join (Environment.GetFolderPath(folder), "MovieManager");
            Directory.CreateDirectory(path);
            
            DbPath = Path.Join(path, "MovieManager.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CrewRole> CrewRoles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MoviePlaylist> MoviePlaylists { get; set; }
        public DbSet<MovieToPlaylist> MovieToPlaylists { get; set; }
    }
}
