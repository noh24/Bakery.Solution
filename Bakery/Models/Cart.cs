namespace Bakery.Models
{
  public abstract class Cart
  {
    public int Count {get; set;}
    public int TotalPrice {get; set;}
    public Cart(int count)
    {
      Count = count;
      TotalPrice = 0;
    }
    public int GetPrice()
    {
      return TotalPrice = Count * 5;
    }
  }
}