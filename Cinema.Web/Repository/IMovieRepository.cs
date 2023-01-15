using Cinema.Web.Models;

namespace Cinema.Web.Repository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<MovieDto>> GetMovies();

        Task<MovieDto> GetMovieById(int movietId);
    }
}
