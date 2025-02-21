using AutoMapper;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Genre;

namespace MovieManager.Services.DataServices
{
    public interface IGenreService : IBaseService
    {
        GenreDto?[] GetGenres();
        GenreDto? GetGenreById(int id);
    }
    public class GenreService : BaseService, IGenreService
    {
        private readonly IMapper _mapper;

        public GenreService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public GenreDto? GetGenreById(int id)
        {
            Genre? genre = _context.Genres.Find(id);
            if (genre == null) { return null; }

            return _mapper.Map<GenreDto>(genre);
        }

        public GenreDto?[] GetGenres()
        {
            return _context.Genres
                .Select(genre => _mapper.Map<GenreDto>(genre)).ToArray();
        }
    }
}
