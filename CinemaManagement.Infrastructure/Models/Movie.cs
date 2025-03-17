using CinemaManagement.Infrastructure.Enums;

namespace CinemaManagement.Infrastructure.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public TimeOnly? DurationMinutes { get; set; }
        public int? Year { get; set; }
        public Genre Genre { get; set; }
        public List<Screening>? Screenings { get; set; }
    }
}
