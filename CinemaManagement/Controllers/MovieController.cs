using CinemaManagement.Domain.Enums;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController(IMovieRepository movieRepository) : ControllerBase
    {
        private readonly IMovieRepository _movieRepository = movieRepository; 
        [HttpGet]
        public void GetMovies()
        {
            _movieRepository.GetAllMovies();
        }
        [HttpDelete]
        public void DeleteMovie(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
        }
        [HttpPost]
        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        //[HttpPatch]
        //public void UpdateMovie(Movie movie, string? title, TimeOnly? durationMinutes, int? year, Genre genre, List<Screening> screenings)
        //{
        //    _movieRepository.UpdateMovie(movie, title, durationMinutes, year, genre, screenings);
        //}
    }
}
