using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.ICommand.ScreeningCommands
{
    public interface ICreateScreeningCommand
    {
        public void CreateScreening(Screening screening);
    }
}
