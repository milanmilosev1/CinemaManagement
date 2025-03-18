namespace CinemaManagement.Domain.Models
{
    public class Screening
    {
        public Guid Id { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
    }
}
