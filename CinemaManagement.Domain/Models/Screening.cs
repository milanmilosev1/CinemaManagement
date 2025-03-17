namespace CinemaManagement.Domain.Models
{
    public class Screening
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public Hall? Hall { get; set; }
        public Movie? Movie { get; set; }
    }
}
