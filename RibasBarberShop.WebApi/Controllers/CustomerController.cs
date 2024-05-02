using Microsoft.AspNetCore.Mvc;
using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        try
        {
            Customer customer = await _customerService.GetCustomerAsync(id);
            return Ok(customer);
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
            List<Customer> customers = await _customerService.GetCustomersAsync();
            return Ok(customers);
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(Customer customer)
    {
        try
        {
            await _customerService.CreateCustomerAsync(customer);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = customer.Id });
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }
}
