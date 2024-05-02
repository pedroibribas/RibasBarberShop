namespace RibasBarberShop.Domain.Entities;

public record Customer(string? Name, string? ContactNumber)
{
    public int Id { get; set; }
    public string? Name { get; private set; } = Name;
    public string? ContactNumber { get; private set; } = ContactNumber;
}