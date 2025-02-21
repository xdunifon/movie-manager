using MovieManager.Services.DataServices;

namespace MovieManager
{
    public static class StartupExtensions
    {
        public static void AddDataServices(this IServiceCollection builderServices)
        {
            builderServices.AddScoped<IMovieService, MovieService>();
            builderServices.AddScoped<IGenreService, GenreService>();
        }
    }
}
