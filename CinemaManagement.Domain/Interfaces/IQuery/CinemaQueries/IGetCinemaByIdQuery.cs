using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries
{
    public interface IGetCinemaByIdQuery
    {
        public Cinema GetCinemaById(Guid id);
    }
}
