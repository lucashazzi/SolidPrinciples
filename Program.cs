Order order = new();
SMSAuth auth = new();
auth.Validate("SMS-0161");
BoaCompraPaymentProcessor processor = new(auth);

order.AddItem("Bananas", 4, 12.5m);
order.AddItem("Óculos", 2, 200.77m);
order.AddItem("Cabo ThunderBolt", 1, 334.90m);

Console.WriteLine(order.TotalPrice());

processor.Pay(order);
