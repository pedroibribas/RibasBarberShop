namespace RibasBarberShop.Domain.Entities;

public record Payment(DateTime Date)
{
    public DateTime Date { get; private set; } = Date;
}
