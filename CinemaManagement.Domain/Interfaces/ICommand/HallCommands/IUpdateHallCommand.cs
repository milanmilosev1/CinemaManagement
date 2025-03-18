using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.HallCommands
{
    public interface IUpdateHallCommand
    {
        public void UpdateHall(Hall hall, string? name, int capacity, int rows, List<Movie>? movies);
    }
}