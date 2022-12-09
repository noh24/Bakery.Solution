namespace Bakery.Models
{
  public class Pastry : Item
  {
    public Pastry(int count) : base(count)
    {
      PricePerUnit = 2;
    }
    public override int GetTotalPrice()
    {
      for (int i = 1; i <= Count; i++)
      {
        if (i % 3 == 0)
        {
          TotalPrice += 1;
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