using RibasBarberShop.Domain.Entities;

namespace RibasBarberShop.Domain.Interfaces;

public interface ICustomerService
{
    Task<Customer> GetCustomerAsync(int id);
    Task<List<Customer>> GetCustomersAsync();
    Task CreateCustomerAsync(Customer customer);
}
