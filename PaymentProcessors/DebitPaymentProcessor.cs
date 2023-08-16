


class DebitPaymentProcessor : IPaymentProcessor
{
    // L - Substituição de Liskov: Elementos de classes filhas devem ser moldados de forma que possamos substituir suas classes pai sem que seja necessário alterações na lógica do programa.
    // Isto implica a criação da propriedade "SecurityCode" em algumas classes e a criação da prop "Email" em outras.
    // Pois é um elemento distinto de classe para classe que interfere no funcionamento.
    private readonly SecurityCodeAuth _authorizer;

    public DebitPaymentProcessor(SecurityCodeAuth authorizer)
    {
        _authorizer = authorizer;
    }
    public void Pay(Order order)
    {
        Console.WriteLine("Processing debit card data info.");
        //I - Interface Segregation (Aqui foi utilizado Composição/Composition): Segregar interfaces com comportamentos distintos (p ex validação de email e codigo de auth).
        //Para solucionar o problema da validação SMS e Auth, foi melhor utilizar a segregação, que cumpre o princípio e deixa o código mais manutenível e legível.
        //Foi criada a interface IAuthenticator para que autenticadores sejam criados a partir dela e cada classe de pagamento possa utilizar o seu.
        if (!_authorizer.IsAuthenticated)
        {
            order.OrderStatus.SetCanceled();
            throw new Exception("Invalid security code for Debit payment processor!");
        }
        Console.WriteLine("Authorization succeeded! Processed debit payment successfully!");
        order.OrderStatus.SetCompleted();
    }
}
