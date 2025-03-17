using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands
{
    public interface IUpdateCinemaCommand
    {
        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls);
    }
}
