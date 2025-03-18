using CinemaManagement.Infrastructure.DataContext;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class CinemaRepository(CinemaDbContext dbContext) : ICinemaRepository
    {
        private readonly CinemaDbContext Context = dbContext;

        public void AddCinema(Cinema cinema)
        {
            Context.Cinemas.Add(cinema);
            Context.SaveChanges();
        }

        public void DeleteCinema(Cinema cinema)
        {
            Context.Cinemas.Remove(cinema);
            Context.SaveChanges();
        }

        public List<Cinema> GetAllCinemas()
        {
            List<Cinema> returnList = [];
            foreach (var cinema in Context.Cinemas)
            {
                returnList.Add(cinema);
            }
            return returnList;
        }

        public Cinema GetCinemaById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls)
        {
            if(cinema != null)
            {
                cinema.Name = name;
                cinema.Location = location;
                cinema.Halls = halls;
            }
            return;
        }

        private IQueryable<Cinema?> GetQueryable()
        {
            var cinemas = Context.Cinemas;

            return cinemas;
        }
    }
}
