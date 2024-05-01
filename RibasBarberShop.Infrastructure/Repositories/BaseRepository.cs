using RibasBarberShop.Domain.Interfaces.Base;

namespace RibasBarberShop.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    public Task Add(T Object)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> List()
    {
        throw new NotImplementedException();
    }

    public Task Update(T Object)
    {
        throw new NotImplementedException();
    }
}
