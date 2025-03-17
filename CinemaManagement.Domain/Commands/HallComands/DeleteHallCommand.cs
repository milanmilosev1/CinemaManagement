using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.HallCommands;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.HallComands
{
    public class DeleteHallCommand(IHallRepository hallRepository) : IDeleteHallCommand
    {
        private readonly IHallRepository _hallRepository = hallRepository;

        public void DeleteHall(Hall hall)
        {
            _hallRepository.DeleteHall(hall);
        }
    }
}
