using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands
{
    public interface ICreateCinemaCommand
    {
        public void AddCinema(Cinema cinema);
    }
}

