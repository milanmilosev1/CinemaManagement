using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.CinemaCommands
{
    public class UpdateCinemaCommand(ICinemaRepository cinemaRepository) : IUpdateCinemaCommand
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;
        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls)
        {
            _cinemaRepository.UpdateCinema(cinema, name, location, halls);
        }
    }
}
