using CinemaManagement.Domain.Interfaces.IQuery.ScreeningQueries;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Queries.ScreeningQueries
{
    public class GetAllScreeningsQuery(IScreeningRepository screeningRepository) : IGetAllScreeningsQuery
    {
        private readonly IScreeningRepository _screeningRepository = screeningRepository;
        public List<Screening> GetAllScreenings()
        {
            return _screeningRepository.GetAllScreenings();
        }
    }
}
