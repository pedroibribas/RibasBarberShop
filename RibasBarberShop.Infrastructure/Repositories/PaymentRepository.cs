using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.Infrastructure.Repositories;

public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
{
}