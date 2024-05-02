namespace RibasBarberShop.Domain.Interfaces.Base;

public interface IBaseRepository<T> where T : class
{
  Task<T> GetById(int id);
  Task<List<T>> ListAsync();
  Task AddAsync(T Object);
  Task Update(T Object);
  Task Delete(string id);
}
