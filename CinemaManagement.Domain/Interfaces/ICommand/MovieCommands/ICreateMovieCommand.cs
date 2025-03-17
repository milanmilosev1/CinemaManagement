using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.MovieCommands
{
    public interface ICreateMovieCommand
    {
        public void AddMovie(Movie movie);
    }
}
