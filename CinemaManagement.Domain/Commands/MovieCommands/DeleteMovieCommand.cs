using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.MovieCommands;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.MovieCommands
{
    public class DeleteMovieCommand(IMovieRepository movieRepository) : IDeleteMovieCommand
    {
        private readonly IMovieRepository _movieRepository = movieRepository;

        public void DeleteMovie(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
        }
    }
}
