namespace Bakery.Models
{
  public class Pastry : Cart
  {
    public Pastry(int count) : base(count)
    {
      TotalPrice = 2;
    }
    public override int GetTotalPrice()
    {
      return TotalPrice = Count * TotalPrice;
    }
  }
}