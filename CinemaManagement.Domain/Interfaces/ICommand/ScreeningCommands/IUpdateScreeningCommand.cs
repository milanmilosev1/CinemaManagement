using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands
{
    public interface IUpdateScreeningCommand
    {
        public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie);
    }
}
