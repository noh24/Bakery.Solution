namespace Bakery.Models
{
  public abstract class Item
  {
    public int Count {get; set;}
    public int PricePerUnit {get; set;}
    public int TotalPrice {get; set;}
    public Item(int count)
    {
      Count = count;
      PricePerUnit = 0;
      TotalPrice = 0;
    }
    public abstract int GetTotalPrice();
  }
}