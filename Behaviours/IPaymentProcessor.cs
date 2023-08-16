//S - Single Responsability: Classe criada pois anteriormente a classe Order continha a função de pagamento, o que feria este princípio.
//class PaymentProcessor
//{

//}

//O - Open/Closed: Princípio que define quais classes estão livres ou não para expansão...
//Comportamentos expansíveis devem ser montados numa interface como feito abaixo:

interface IPaymentProcessor {
    public void Pay(Order order);
}
