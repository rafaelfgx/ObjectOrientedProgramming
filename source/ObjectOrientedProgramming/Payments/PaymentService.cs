namespace ObjectOrientedProgramming;

public sealed class PaymentService(IPayment payment)
{
    public void Pay(decimal value) => payment.Pay(value);
}
