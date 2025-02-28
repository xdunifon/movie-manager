using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieManager.Models.Database;
using MovieManager.Models.Dtos.Genre;

namespace MovieManager.Services.DataServices
{
    public interface IGenreService : IBaseService
    {
        Task<GenreDto?[]> GetGenres();
        Task<GenreDto?> GetGenreById(int id);
    }
    public class GenreService : BaseService, IGenreService
    {
        private readonly IMapper _mapper;

        public GenreService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<GenreDto?> GetGenreById(int id)
        {
            Genre? genre = await _context.Genres.FindAsync(id);
            if (genre == null) { return null; }

            return _mapper.Map<GenreDto>(genre);
        }

        public async Task<GenreDto?[]> GetGenres()
        {
            return await _context.Genres
                .Select(genre => _mapper.Map<GenreDto>(genre)).ToArrayAsync();
        }
    }
}
