
public abstract class Order
{
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
    public int Quantity { get; set; }
    public decimal SubTotal { get; set; }
    public decimal GrandTotal { get; set; }
}

