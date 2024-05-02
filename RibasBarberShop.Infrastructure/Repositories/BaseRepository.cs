using Microsoft.EntityFrameworkCore;
using RibasBarberShop.Domain.Interfaces.Base;
using RibasBarberShop.Infrastructure.Configuration;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace RibasBarberShop.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
{
    private readonly DbContext _db;

    // To detect redundant calls
    private bool _disposedValue;
    // Instantiate a SafeHandle instance.
    private SafeHandle? _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

    public BaseRepository()
    {
        _db = new SchedulingContext();
    }

    public async Task AddAsync(T Object)
    {
        await _db.Set<T>().AddAsync(Object);
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<T>> ListAsync()
    {
        return await _db.Set<T>().ToListAsync();
    }

    public Task Update(T Object)
    {
        throw new NotImplementedException();
    }

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _safeHandle?.Dispose();
                _safeHandle = null;
            }

            _disposedValue = true;
        }
    }
}
