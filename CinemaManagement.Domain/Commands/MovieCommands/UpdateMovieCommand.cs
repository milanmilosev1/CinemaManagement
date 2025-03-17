using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.MovieCommands;
using CinemaManagement.Domain.Models;
using CinemaManagement.Infrastructure.Enums;

namespace CinemaManagement.Domain.Commands.MovieCommands
{
    public class UpdateMovieCommand(IMovieRepository movieRepository) : IUpdateMovieCommand
    {
        private readonly IMovieRepository _movieRepository = movieRepository;
        public void UpdateMovie(Movie movie, string? title, TimeOnly? durationMinutes, int? year, Genre genre, List<Screening> screenings)
        {
            _movieRepository.UpdateMovie(movie, title, durationMinutes, year, genre, screenings);
        }
    }
}
