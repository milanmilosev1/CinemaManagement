using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        public List<Cinema> Cinemas = [];
        public void AddCinema(Cinema cinema)
        {
            Cinemas.Add(cinema);
        }

        public void DeleteCinema(Cinema cinema)
        {
            Cinemas.Remove(cinema);
        }

        public List<Cinema> GetAllCinemas()
        {
            List<Cinema> returnList = [];
            foreach(var cinema in Cinemas)
            {
                returnList.Add(cinema);
            }
            return returnList;
        }

        public Cinema GetCinemaById(Guid id)
        {
            return Cinemas.FirstOrDefault(x => x.Id == id)!;
        }

        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls)
        {
            // TO BE IMPLEMENTED
            return;
        }
    }
}
