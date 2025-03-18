using CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.CinemaCommands
{
    public class CreateCinemaCommand(ICinemaRepository cinemaRepository) : ICreateCinemaCommand
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;

        public void AddCinema(Cinema cinema)
        {
            _cinemaRepository.AddCinema(cinema);
        }
    }
}
