namespace RibasBarberShop.Domain.Entities;

public record ScheduledDate(DateTime Date, Customer? Customer, Payment? Payment, int id)
{
  public int Id { get; set; }
  public DateTime Date { get; private set; } = Date;
  public Customer? Customer { get; private set; } = Customer;
  public Payment? Payment { get; private set; } = Payment;
}
