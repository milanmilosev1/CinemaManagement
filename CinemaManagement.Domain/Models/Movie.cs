using CinemaManagement.Infrastructure.Enums;

namespace CinemaManagement.Domain.Models
{
    public class Movie
    {
        public string? Title { get; set; }
        public TimeOnly? DurationMinutes { get; set; }
        public int? Year { get; set; }
        public Genre Genre { get; set; }
        public List<Screening>? Screenings { get; set; }
    }
}
