using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces
{
    public interface IHallRepository
    {
        public void AddHall(Hall hall);
        public void DeleteHall(Hall hall);
        public void UpdateHall(Hall hall, string? name, int capacity, int rows, Cinema? cinema, List<Movie>? movies);
    }
}
