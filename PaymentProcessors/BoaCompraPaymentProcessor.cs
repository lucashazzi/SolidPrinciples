


class BoaCompraPaymentProcessor : IPaymentProcessor
{
    private readonly SMSAuth _authorizer;

    public BoaCompraPaymentProcessor(SMSAuth authorizer)
    {
        _authorizer = authorizer;
    }

    public void Pay(Order order)
    {
        Console.WriteLine("Processing BoaCompra data.");

        if (_authorizer.IsAuthenticated)
        {
            Console.WriteLine("User is validated and payment with BoaCompra is completed!");
            order.OrderStatus.SetCompleted();
        }
        else
        {
            order.OrderStatus.SetCanceled();
            throw new Exception("User not authenticated correctly with BoaCompra!");
        }
    }
}
