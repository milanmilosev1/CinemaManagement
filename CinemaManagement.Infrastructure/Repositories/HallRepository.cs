using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class HallRepository : IHallRepository
    {
        public List<Hall> Halls = [];
        public void AddHall(Hall hall)
        {
            Halls.Add(hall);
        }

        public void DeleteHall(Hall hall)
        {
            Halls.Remove(hall);
        }

        public void UpdateHall(Hall hall, string? name, int capacity, int rows, Cinema? cinema, List<Movie>? movies)
        {
            //TO BE IMPLEMENTED
            return;
        }
    }
}
