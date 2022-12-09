namespace Bakery.Models
{
  public class Pastry : Item
  {
    public Pastry(int count) : base(count)
    {
      PricePerUnit = 2;
      DiscountPrice = 1;
    }
  }
}