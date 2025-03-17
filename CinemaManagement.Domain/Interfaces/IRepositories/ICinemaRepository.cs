using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IRepositories
{
    public interface ICinemaRepository
    {
        public void AddCinema(Cinema cinema);
        public void DeleteCinema(Cinema cinema);
        public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls);
        public List<Cinema> GetAllCinemas();
        public Cinema GetCinemaById(Guid id);
    }
}
