using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.HallCommands
{
    public interface IDeleteHallCommand
    {
        public void DeleteHall(Hall hall);
    }
}
