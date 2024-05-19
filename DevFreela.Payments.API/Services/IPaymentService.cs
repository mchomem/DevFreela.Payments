namespace DevFreela.Payments.API.Services;

public interface IPaymentService
{
    Task<bool> ProcessPaymentAsync(PaymentInfoInputModel payment);
}
