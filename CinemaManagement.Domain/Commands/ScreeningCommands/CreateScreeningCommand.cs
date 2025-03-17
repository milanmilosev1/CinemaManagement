using CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.ScreeningCommands
{
    public class CreateScreeningCommand(IScreeningRepository screeningRepository) : ICreateScreeningCommand
    {
        private readonly IScreeningRepository _screeningRepository = screeningRepository;
        public void CreateScreening(Screening screening)
        {
            _screeningRepository.AddScreening(screening);
        }
    }
}
