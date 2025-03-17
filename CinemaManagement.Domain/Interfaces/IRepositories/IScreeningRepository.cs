using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IRepositories
{
    public interface IScreeningRepository
    {
        public void AddScreening(Screening screening);
        public void DeleteScreening(Screening screening);
        public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie);
        public List<Screening> GetAllScreenings();
    }
}
