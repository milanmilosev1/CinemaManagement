using CinemaManagement.Domain.Models;
using CinemaManagement.Domain.Enums;

namespace CinemaManagement.Domain.Interfaces.IRepositories
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        public void DeleteMovie(Movie movie);
        public void UpdateMovie(Movie movie, string? title, int? durationMinutes, int? year, Genre genre, List<Screening> screenings);
        public List<Movie> GetAllMovies();
    }
}
