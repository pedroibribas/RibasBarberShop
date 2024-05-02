using Microsoft.AspNetCore.Mvc;
using RibasBarberShop.Domain.Entities;
using RibasBarberShop.Domain.Interfaces;

namespace RibasBarberShop.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        try
        {
            Payment payment = await _paymentService.GetPaymentAsync(id);
            return Ok(payment);
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
            List<Payment> payments = await _paymentService.GetPaymentsAsync();
            return Ok(payments);
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(Payment payment)
    {
        try
        {
            await _paymentService.CreatePaymentAsync(payment);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = payment.Id });
        }
        catch (Exception ex)
        {
            return Problem(ex.ToString());
        }
    }
}