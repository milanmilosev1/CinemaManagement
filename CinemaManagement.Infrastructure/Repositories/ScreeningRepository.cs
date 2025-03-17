using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        public List<Screening> Screenings = [];
        public void AddScreening(Screening screening)
        {
            Screenings.Add(screening);
        }

        public void DeleteScreening(Screening screening)
        {
            Screenings.Remove(screening);
        }

        public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie)
        {
            return;
        }
    }
}
