using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IQuery.MovieQueries
{
    public interface IGetAllMoviesQuery
    {
        public List<Movie> GetAllMovies();
    }
}
