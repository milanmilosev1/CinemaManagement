using CinemaManagement.Domain.Interfaces.ICommand.CinemaCommands;
using CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries;
using CinemaManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CinemaController(ICreateCinemaCommand createCinemaCommand, IDeleteCinemaCommand deleteCinemaCommand) : ControllerBase
    {
        private readonly ICreateCinemaCommand _createCinemaCommand = createCinemaCommand;
        private readonly IDeleteCinemaCommand _deleteCinemaCommand = deleteCinemaCommand;

        //[HttpGet]
        //public List<Cinema> GetCinemas()
        //{
        //    return getAllCinemasQuery.GetAllCinemas();
        //}

        [HttpDelete]
        public void DeleteCinema(Cinema cinema)
        {
            _deleteCinemaCommand.DeleteCinema(cinema);
        }

        [HttpPost]
        public void AddCinema([FromBody]Cinema cinema)
        {
            _createCinemaCommand.AddCinema(cinema);
        }

        //[HttpPatch]
        //public void UpdateCinema(Cinema cinema, string? name, string? location, List<Hall> halls)
        //{
        //    _cinemaRepository.UpdateCinema(cinema, name, location, halls);
        //}
    }
}
