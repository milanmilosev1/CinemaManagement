using CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Queries.CinemaQueries
{
    public class GetCinemaByIdQuery(ICinemaRepository cinemaRepository) : IGetCinemaByIdQuery
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;

        public Cinema GetCinemaById(Guid id)
        {
            return _cinemaRepository.GetCinemaById(id);
        }
    }
}
