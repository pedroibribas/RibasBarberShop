using RibasBarberShop.Domain.Entities;

namespace RibasBarberShop.Domain.Interfaces;

public interface IPaymentService
{
    Task<Payment> GetPaymentAsync(int id);
    Task<List<Payment>> GetPaymentsAsync();
    Task CreatePaymentAsync(Payment payment);
}
