using CinemaManagement.Domain.Interfaces.IQuery.MovieQueries;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Queries.MovieQueries
{
    public class GetAllMoviesQuery(IMovieRepository movieRepository) : IGetAllMoviesQuery
    {
        private readonly IMovieRepository _movieRepository = movieRepository;
        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }
    }
}
