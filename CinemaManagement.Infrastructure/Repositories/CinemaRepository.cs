using CinemaManagement.Domain.Interfaces;
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

        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls)
        {
            // TO BE IMPLEMENTED
            return;
        }
    }
}
