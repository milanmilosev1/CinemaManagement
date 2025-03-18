using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaManagement.Infrastructure.Models
{
    public class Hall
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Capacity { get; set; }
        public int Rows { get; set; }
        [ForeignKey("Cinema")]
        public Guid CinemaId { get; set; }
        public Cinema Cinema { get; set; } = new();
        [ForeignKey("Screening")]
        public Guid ScreeningId { get; set; }

    }
}
