using CinemaManagement.Domain.Models;
using CinemaManagement.Domain.Enums;

namespace CinemaManagement.Domain.Interfaces.ICommand.MovieCommands
{
    public interface IUpdateMovieCommand
    {
        public void UpdateMovie(Movie movie, string? title, int? durationMinutes, int? year, Genre genre, List<Screening> screenings);
    }
}
