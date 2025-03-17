using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IQuery.HallQueries
{
    public interface IGetAllHallsQuery
    {
        public List<Hall> GetAllHalls();
    }
}
