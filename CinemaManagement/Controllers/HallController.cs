using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HallController(IHallRepository hallRepository) : ControllerBase
    {
        private readonly IHallRepository _hallRepository = hallRepository;
        [HttpGet]
        public void GetHalls()
        {
            _hallRepository.GetAllHalls();
        }

        [HttpDelete]
        public void DeleteHall(Hall hall)
        {
            _hallRepository.DeleteHall(hall);
        }

        [HttpPost]
        public void AddHall(Hall hall)
        {
            _hallRepository.AddHall(hall);
        }

        //[HttpPatch]
        //public void UpdateHall(Hall hall, string? name, int capacity, int rows, List<Movie>? movies)
        //{
        //    _hallRepository.UpdateHall(hall, name, capacity, rows, movies);
        //}

    }
}
