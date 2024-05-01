using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.Domain.Services;

public class ScheduledDateService(IScheduledDateRepository scheduledDateRepository) : IScheduledDateService
{
    private readonly IScheduledDateRepository _scheduledDateRepository = scheduledDateRepository;

    public async Task<List<ScheduledDate>> GetScheduledDates()
    {
        List<ScheduledDate> scheduledDates = await _scheduledDateRepository.List();
        return scheduledDates;
    }

    public async Task CreateScheduledDate(ScheduledDate scheduledDate)
    {
        await _scheduledDateRepository.Add(scheduledDate);
    }
}
