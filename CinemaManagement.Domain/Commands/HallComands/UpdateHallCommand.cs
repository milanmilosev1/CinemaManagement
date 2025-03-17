using CinemaManagement.Domain.Interfaces;
using CinemaManagement.Domain.Interfaces.ICommand.HallCommands;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Commands.HallComands
{
    public class UpdateHallCommand(IHallRepository hallRepository) : IUpdateHallCommand
    {
        private readonly IHallRepository _hallRepository = hallRepository;

        public void UpdateHall(Hall hall, string? name, int capacity, int rows, Cinema? cinema, List<Movie>? movies)
        {
            _hallRepository.UpdateHall(hall, name, capacity, rows, cinema, movies);
        }
    }
}
