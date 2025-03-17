using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands
{
    public interface IDeleteCinemaCommand
    {
        public void DeleteCinema(Cinema cinema);
    }
}
