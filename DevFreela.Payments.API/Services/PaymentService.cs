namespace DevFreela.Payments.API.Services;

public class PaymentService : IPaymentService
{
    public async Task<bool> ProcessPaymentAsync(PaymentInfoInputModel payment)
    {
        // Implementação abstrata para representar um microserviço de pagamento.

        return await Task.FromResult(true);
    }
}
