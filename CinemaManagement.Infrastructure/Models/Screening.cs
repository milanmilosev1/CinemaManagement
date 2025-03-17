namespace CinemaManagement.Infrastructure.Models
{
    public class Screening
    {
        public Guid Id { get; set; }
        public TimeOnly StartTime { get; set; } 
        public TimeOnly EndTime { get; set; } 
        public Hall? Hall { get; set; } 
        public Movie? Movie { get; set; } 
    }
}
