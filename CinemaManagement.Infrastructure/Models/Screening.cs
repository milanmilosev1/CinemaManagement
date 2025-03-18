using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagement.Infrastructure.Models
{
    public class Screening
    {
        [Key]
        public Guid Id { get; set; }
        public string? StartTime { get; set; } 
        public string? EndTime { get; set; }
        [ForeignKey("Hall")]
        public Guid HallId { get; set; }
        public Hall? Hall { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; } 
    }
}
