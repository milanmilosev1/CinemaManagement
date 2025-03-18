using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using CinemaManagement.Infrastructure.DataContext;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class ScreeningRepository : IScreeningRepository
    {
        private readonly CinemaDbContext Context;
        public void AddScreening(Screening screening)
        {
            Context.Screenings.Add(screening);
            Context.SaveChanges();
        }

        public void DeleteScreening(Screening screening)
        {
            Context.Screenings.Remove(screening);
        }

        public List<Screening> GetAllScreenings()
        {
            List<Screening> returnList = [];
            foreach(var s in Context.Screenings)
            {
                returnList.Add(s);
            }
            return returnList;
        }

        public void UpdateScreening(Screening screening, string? startTime, string? endTime)
        {
            if(screening != null)
            {
                screening.StartTime = startTime;
                screening.EndTime = endTime;
            }
            return;
        }
    }
}
