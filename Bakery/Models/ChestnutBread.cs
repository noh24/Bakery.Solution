namespace Bakery.Models
{
  public class ChestnutBread : Bread
  {
    public ChestnutBread(int count) : base(count)
    {
      PricePerUnit = 7;
      DiscountPrice = 2;
    }
  }
}