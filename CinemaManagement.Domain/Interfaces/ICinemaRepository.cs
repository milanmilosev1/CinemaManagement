using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces
{
    public interface ICinemaRepository
    {
        public void AddCinema(Cinema cinema);
        public void DeleteCinema(Cinema cinema);
        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls);
    }
}
