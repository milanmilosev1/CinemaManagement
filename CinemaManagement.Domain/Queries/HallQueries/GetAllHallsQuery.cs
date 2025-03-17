using CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries;
using CinemaManagement.Domain.Interfaces.IQuery.HallQueries;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Queries.HallQueries
{
    public class GetAllHallsQuery(IHallRepository hallRepository) : IGetAllHallsQuery   
    {
        private readonly IHallRepository _hallReposotiry = hallRepository;
        public List<Hall> GetAllHalls()
        {
            return _hallReposotiry.GetAllHalls();
        }
    }
}
