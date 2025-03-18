using System.ComponentModel.DataAnnotations;

namespace CinemaManagement.Infrastructure.Models
{
    public class Cinema
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public List<Hall>? Halls { get; set; }
    }
}
