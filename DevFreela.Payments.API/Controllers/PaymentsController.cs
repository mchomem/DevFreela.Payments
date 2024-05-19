namespace DevFreela.Payments.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentsController(IPaymentService paymentService)
        => _paymentService = paymentService;

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel payment)
    {
        var result = await _paymentService.ProcessPaymentAsync(payment);

        if (!result)
            return BadRequest();

        return NoContent();
    }
}
