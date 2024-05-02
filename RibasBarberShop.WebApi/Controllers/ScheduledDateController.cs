using Microsoft.AspNetCore.Mvc;
using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ScheduledDateController : ControllerBase
{
    private readonly IScheduledDateService _scheduledDateService;

    public ScheduledDateController(IScheduledDateService scheduledDateService)
    {
        _scheduledDateService = scheduledDateService;
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        try
        {
            ScheduledDate scheduledDate = await _scheduledDateService.GetScheduledDateAsync(id);
            return Ok(scheduledDate);
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }

    [HttpGet]
    public async Task<IActionResult> ListAsync()
    {
        try
        {
            List<ScheduledDate> scheduledDates = await _scheduledDateService.GetScheduledDatesAsync();
            return Ok(scheduledDates);
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(ScheduledDate scheduledDate)
    {
        try
        {
            await _scheduledDateService.CreateScheduledDateAsync(scheduledDate);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = scheduledDate.Id });
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }
}
