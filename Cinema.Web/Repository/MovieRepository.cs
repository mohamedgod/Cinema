using AutoMapper;
using Cinema.Web.DbContexts;
using Cinema.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public MovieRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<MovieDto> GetMovieById(int movietId)
        {
            var movie = await _db.Movies.FindAsync(movietId);

            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<IEnumerable<MovieDto>> GetMovies()
        {
            var movies = await _db.Movies.ToListAsync();

            return _mapper.Map<List<MovieDto>>(movies);
        }
    }
}
