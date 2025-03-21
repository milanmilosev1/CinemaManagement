﻿using CinemaManagement.Domain.Models;

namespace CinemaManagement.Domain.Interfaces.IRepositories
{
    public interface IHallRepository
    {
        public void AddHall(Hall hall);
        public void DeleteHall(Hall hall);
        public void UpdateHall(Hall hall, string? name, int capacity, int rows, List<Movie>? movies);
        public List<Hall> GetAllHalls();
    }
}
