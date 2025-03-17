using CinemaManagement.Domain.Enums;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> Movies = [];
        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            Movies.Remove(movie);
        }

        public void UpdateMovie(Movie movie, string? title, TimeOnly? durationMinutes, int? year, Genre genre, List<Screening> screenings)
        {
            return;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> returnList = [];
            foreach(var movie in Movies)
            {
                returnList.Add(movie);
            }
            return returnList;
        }
    }
}
