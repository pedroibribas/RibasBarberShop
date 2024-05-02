using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.Domain.Services;

public class PaymentService : IPaymentService
{
    public Task CreatePaymentAsync(Payment payment)
    {
        throw new NotImplementedException();
    }

    public Task<Payment> GetPaymentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Payment>> GetPaymentsAsync()
    {
        throw new NotImplementedException();
    }
}
