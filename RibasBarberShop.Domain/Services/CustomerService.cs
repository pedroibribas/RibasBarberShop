using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.Domain.Services;

public class CustomerService : ICustomerService
{
    public Task CreateCustomerAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetCustomerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetCustomersAsync()
    {
        throw new NotImplementedException();
    }
}
