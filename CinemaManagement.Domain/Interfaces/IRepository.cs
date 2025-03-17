namespace CinemaManagement.Domain.Interfaces
{
    public interface IRepository<T> 
    {
        public void AddToRepo(T entity);
        public void DeleteFromRepo(T entity);
        public void Update(T entity);
        public List<T> GetAll();
    }
}
