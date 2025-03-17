using CinemaManagement.Domain.Models;
using CinemaManagement.Infrastructure.Enums;

namespace CinemaManagement.Domain.Interfaces
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        public void DeleteMovie(Movie movie);
        public void UpdateMovie(Movie movie, string? title, TimeOnly? durationMinutes, int? year, Genre genre, List<Screening> screenings);
    }
}
