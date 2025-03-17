using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CinemaController(ICinemaRepository cinemaRepository) : ControllerBase
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;

        [HttpGet]
        public List<Cinema> GetCinemas()
        {
            return _cinemaRepository.GetAllCinemas();
        }

        [HttpDelete]
        public void DeleteCinema(Cinema cinema)
        {
            _cinemaRepository.DeleteCinema(cinema);
        }

    }
}
