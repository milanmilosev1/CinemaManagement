using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands
{
    public interface IDeleteScreeningCommand
    {
        public void DeleteScreening(Screening screening);
    }
}
