


class Order
{
    public readonly Status OrderStatus = Status.Open;
    
    private readonly List<string> Items = new();

    private readonly List<int> Quantities = new();

    private readonly List<decimal> Prices = new();

    public void AddItem(string item, int qty, decimal price)
    {
        Items.Add(item);
        Quantities.Add(qty);
        Prices.Add(price);
        OrderStatus.SetInProgress();
    }

    public decimal TotalPrice()
    {
        decimal total = 0;

        for (int i = 0; i < Prices.Count; i++)
            total += Prices[i] * Quantities[i];

        return total;
    }

   
}
