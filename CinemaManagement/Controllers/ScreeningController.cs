using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScreeningController(IScreeningRepository screeningRepository) : ControllerBase
    {
        private readonly IScreeningRepository _screeningRepository = screeningRepository;
        [HttpGet]
        public void GetScreenings()
        {
            _screeningRepository.GetAllScreenings();
        }

        [HttpDelete]
        public void DeleteScreening(Screening screening)
        {
            _screeningRepository.DeleteScreening(screening);
        }

        [HttpPost]
        public void AddScreenings(Screening screening)
        {
            _screeningRepository.AddScreening(screening);
        }

        //[HttpPatch]
        //public void UpdateScreening(Screening screening, TimeOnly startTime, TimeOnly endTime, Hall? hall, Movie? movie)
        //{
        //    _screeningRepository.UpdateScreening(screening, startTime, endTime, hall, movie);
        //}
    }
}
