using CinemaManagement.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagement.Infrastructure.Models
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public int? DurationMinutes { get; set; }
        public int? Year { get; set; }
        public Genre Genre { get; set; }
        public List<Screening>? Screenings { get; set; }
    }
}
