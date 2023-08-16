


class CreditPaymentProcessor : IPaymentProcessor
{
    private readonly SecurityCodeAuth _authorizer;
    public CreditPaymentProcessor(SecurityCodeAuth authorizer)
    {
        _authorizer = authorizer;
    }

    public void Pay(Order order)
    {
        Console.WriteLine("Processing credit card data info.");

        if (!_authorizer.IsAuthenticated)
        {
            order.OrderStatus.SetCanceled();
            throw new Exception("Invalid security code for Credit payment processor!");
        }

        Console.WriteLine("Authorization succeeded! Processed credit payment successfully!");
        order.OrderStatus.SetCompleted();
    }
}
