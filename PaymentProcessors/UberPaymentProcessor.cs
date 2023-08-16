


class UberPaymentProcessor : IPaymentProcessor
{
    private readonly IAuthorizer _authorizer;

    public UberPaymentProcessor(IAuthorizer authorizer)
    {
        _authorizer = authorizer;
    }

    public void Pay(Order order)
    {
        string auth = "AAGG4132";
        if (!_authorizer.Validate(auth))
            throw new Exception($"Invalid authorization number {auth} for UberPayment method! Validation used {_authorizer.GetType()}");
    }
}
