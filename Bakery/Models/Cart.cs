namespace Bakery.Models
{
  public class Cart
  {
    private static int _totalBread {get; set;}
    private static int _totalPastry {get; set;}
    private static int _totalPrice {get; set;}
    public static int AddTotalBread(int bread)
    {
      return _totalBread += bread;
    }
    public static int AddTotalPastry(int pastry)
    {
      return _totalPastry += pastry;
    }
    public static int GetTotalPrice(int bread, int pastry)
    {
      return _totalPrice = bread + pastry;
    }
  }
}