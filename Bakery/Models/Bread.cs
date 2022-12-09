namespace Bakery.Models
{
  public class Bread : Item
  {
    public Bread(int count) : base(count)
    {
      PricePerUnit = 5;
      DiscountPrice = 0;
    }
  }
}