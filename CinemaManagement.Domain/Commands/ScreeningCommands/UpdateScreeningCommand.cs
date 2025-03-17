using CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.ScreeningCommands
{
    public class UpdateScreeningCommand(IScreeningRepository screeningRepository) : IUpdateScreeningCommand
    {
        private readonly IScreeningRepository _screeningRepository = screeningRepository;
        public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie)
        {
            _screeningRepository.UpdateScreening(screening, startTime, endTime, hall, movie);
        }
    }
}
