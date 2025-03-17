using CinemaManagement.Domain.Interfaces.IRepositories;
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

        public List<Screening> GetAllScreenings()
        {
            List<Screening> returnList = [];
            foreach(var s in Screenings)
            {
                returnList.Add(s);
            }
            return returnList;
        }

        public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie)
        {
            return;
        }
    }
}
