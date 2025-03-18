using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Infrastructure.DataContext;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class HallRepository(CinemaDbContext dbContext) : IHallRepository
    {
        private readonly CinemaDbContext Context = dbContext;
        public void AddHall(Hall hall)
        {
            Context.Halls.Add(hall);
            Context.SaveChanges();
        }

        public void DeleteHall(Hall hall)
        {
            Context.Halls.Remove(hall);
            Context.SaveChanges();
        }

        public List<Hall> GetAllHalls()
        {
            List<Hall> returnHalls = [];
            foreach(var hall in Context.Halls)
            {
                returnHalls.Add(hall);
            }
            return returnHalls;
        }

        public void UpdateHall(Hall hall, string? name, int capacity, int rows, List<Movie>? movies)
        {
            //TO BE IMPLEMENTED
            return;
        }
    }
}
