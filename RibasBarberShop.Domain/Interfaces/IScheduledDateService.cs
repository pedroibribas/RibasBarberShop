using RibasBarberShop.Domain.Entities;

namespace RibasBarberShop.Domain.Interfaces;

public interface IScheduledDateService
{
  Task<ScheduledDate> GetScheduledDateAsync(int id);
  Task<List<ScheduledDate>> GetScheduledDatesAsync();
  Task CreateScheduledDateAsync(ScheduledDate scheduledDate);
}
