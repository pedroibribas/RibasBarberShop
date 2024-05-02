namespace RibasBarberShop.Domain.Entities;

public record Payment(DateTime Date)
{
    public int Id { get; set; }
    public DateTime Date { get; private set; } = Date;
}
