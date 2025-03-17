using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.HallCommands;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.HallComands
{
    public class CreateHallCommand(IHallRepository hallRepository) : ICreateHallCommand
    {
        private readonly IHallRepository _hallRepository = hallRepository;

        public void CreateHall(Hall hall)
        {
            _hallRepository.AddHall(hall);
        }
    }
}
