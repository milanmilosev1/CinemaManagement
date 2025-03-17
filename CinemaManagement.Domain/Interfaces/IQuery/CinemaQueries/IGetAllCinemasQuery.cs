using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries
{
    public interface IGetAllCinemasQuery
    {
        public List<Cinema> GetAllCinemas();
    }
}
