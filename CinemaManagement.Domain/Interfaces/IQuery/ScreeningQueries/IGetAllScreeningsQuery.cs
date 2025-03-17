using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IQuery.ScreeningQueries
{
    public interface IGetAllScreeningsQuery
    {
        public List<Screening> GetAllScreenings();
    }
}
