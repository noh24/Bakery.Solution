namespace Bakery.Models
{
  public class Cart
  {
    public static int TotalBread {get; set;}
    public static int TotalPastry {get; set;}
    public static int TotalPrice {get; set;}
    public static int AddTotalBread(int bread)
    {
      return TotalBread += bread;
    }
    public static int AddTotalPastry(int pastry)
    {
      return TotalPastry += pastry;
    }
    public static int GetTotalPrice(int bread, int pastry)
    {
      return TotalPrice = bread + pastry;
    }
  }
}