using CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using System.Numerics;

namespace CinemaManagement.Domain.Commands.ScreeningCommands
{
    public class DeleteScreeningCommand(IScreeningRepository screeningRepository) : IDeleteScreeningCommand
    {
        private readonly IScreeningRepository _screeningRepository = screeningRepository;

        public void DeleteScreening(Screening screening)
        {
            _screeningRepository.DeleteScreening(screening);
        }
    }
}
