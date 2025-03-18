namespace CinemaManagement.Domain.Models
{
    public class Hall
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Capacity { get; set; }
        public int Rows { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
