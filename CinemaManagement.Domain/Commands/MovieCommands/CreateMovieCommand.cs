using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.MovieCommands;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.MovieCommands
{
    public class CreateMovieCommand(IMovieRepository movieRepository) : ICreateMovieCommand
    {
        private readonly IMovieRepository _movieRepository = movieRepository;

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
    }
}
