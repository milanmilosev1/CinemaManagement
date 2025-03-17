using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.MovieCommands
{
    public interface IDeleteMovieCommand
    {
        public void DeleteMovie(Movie movie);
    }
}
