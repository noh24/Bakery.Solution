namespace Bakery.Models
{
  public class Cart
  {
    private static int _totalItems {get; set;}
    private static int _totalPrice {get; set;}
    public static int AddItems(int bread, int pastry)
    {
      return _totalItems = bread + pastry;
    }
  }
}