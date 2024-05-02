using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.Domain.Services;

public class ScheduledDateService(IScheduledDateRepository scheduledDateRepository) : IScheduledDateService
{
    private readonly IScheduledDateRepository _scheduledDateRepository = scheduledDateRepository;

    public async Task<ScheduledDate> GetScheduledDateAsync(int id)
    {
        ScheduledDate scheduledDates = await _scheduledDateRepository.GetById(id);
        return scheduledDates;
    }

    public async Task<List<ScheduledDate>> GetScheduledDatesAsync()
    {
        List<ScheduledDate> scheduledDates = await _scheduledDateRepository.ListAsync();
        return scheduledDates;
    }

    public async Task CreateScheduledDateAsync(ScheduledDate scheduledDate)
    {
        await _scheduledDateRepository.AddAsync(scheduledDate);
    }
}
