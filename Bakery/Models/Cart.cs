namespace Bakery.Models
{
  public abstract class Cart
  {
    public int Count {get; set;}
    public int TotalPrice {get; set;}
    public Cart(int count, int totalPrice)
    {
      Count = count;
      TotalPrice = totalPrice;
    }
  }
}