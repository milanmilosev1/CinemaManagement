using CinemaManagement.Domain.Interfaces;

namespace CinemaManagement.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly List<T> Entities = [];
        public void AddToRepo(T entity)
        {
            Entities.Add(entity);
        }

        public void DeleteFromRepo(T entity)
        {
            return;
        }

        public List<T> GetAll()
        {
            List<T> returnList = [];
            foreach(var e in Entities)
            {
                returnList.Add(e);
            }
            return returnList;
        }

        public void Update(T entity)
        {
            return;
        }
    }
}
