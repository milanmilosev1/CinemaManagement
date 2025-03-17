using CinemaManagement.Domain.Enums;

namespace CinemaManagement.Domain.Models
{
    public class Movie
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public TimeOnly? DurationMinutes { get; set; }
        public int? Year { get; set; }
        public Genre Genre { get; set; }
        public List<Screening>? Screenings { get; set; }
    }
}
