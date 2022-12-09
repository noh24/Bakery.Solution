namespace Bakery.Models
{
  public abstract class Item
  {
    public int Count {get; set;}
    public int PricePerUnit {get; set;}
    public int TotalPrice {get; set;}
    public int DiscountPrice {get; set;}
    public Item(int count)
    {
      Count = count;
      TotalPrice = 0;
    }
    public int GetTotalPrice()
    {
        for (int i = 1; i <= Count; i++)
        {
          if (i % 3 == 0) // for every third purchase, use discount price
          {
            TotalPrice += DiscountPrice;
          }
          else
          {
            TotalPrice += PricePerUnit;
          }
        }
      return TotalPrice;
    }
  }
}