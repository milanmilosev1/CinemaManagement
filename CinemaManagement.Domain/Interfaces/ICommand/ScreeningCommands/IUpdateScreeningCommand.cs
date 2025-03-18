using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands
{
    public interface IUpdateScreeningCommand
    {
        public void UpdateScreening(Screening screening, string? startTime, string? endTime);
    }
}
