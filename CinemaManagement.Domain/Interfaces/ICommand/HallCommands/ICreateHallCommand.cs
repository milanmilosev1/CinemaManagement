using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.HallCommands
{
    public interface ICreateHallCommand
    {
        public void CreateHall(Hall hall);
    }
}
