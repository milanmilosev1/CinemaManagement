using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.CinemaCommands
{
    public class DeleteCinemaCommand(ICinemaRepository cinemaRepository) : IDeleteCinemaCommand
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;
        public void DeleteCinema(Cinema cinema)
        {
            _cinemaRepository.DeleteCinema(cinema);
        }
    }
}
