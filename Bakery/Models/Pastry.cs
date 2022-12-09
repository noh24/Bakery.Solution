namespace Bakery.Models
{
  public class Pastry : Cart
  {
    public Pastry(int count) : base(count)
    {
    }
    public override int GetTotalPrice()
    {
      return TotalPrice = 2;
    }
  }
}