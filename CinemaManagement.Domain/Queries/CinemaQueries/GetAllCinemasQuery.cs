﻿using CinemaManagement.Domain.Interfaces.IQuery.CinemaQueries;
using CinemaManagement.Domain.Interfaces.IRepositories;
using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Queries.CinemaQueries
{
    public class GetAllCinemasQuery(ICinemaRepository cinemaRepository) : IGetAllCinemasQuery
    {
        private readonly ICinemaRepository _cinemaRepository = cinemaRepository;
        public List<Cinema> GetAllCinemas()
        {
            return _cinemaRepository.GetAllCinemas();
        }
    }
}
