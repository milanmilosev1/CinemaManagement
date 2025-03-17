namespace CinemaManagement.Domain.Models
{
    public class Cinema
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public List<Hall>? Halls { get; set; }
    }
}
