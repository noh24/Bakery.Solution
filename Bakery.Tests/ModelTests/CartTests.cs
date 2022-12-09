using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class CartTest
  {
    [TestMethod]
    public void AddItems_AddBreadAndPastryCount_Int()
    {
      Bread bread = new Bread(1);
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, Cart.AddItems(bread.Count, pastry.Count));
    }
    [TestMethod]
    public void GetTotalPrice_AddBreadAndPastryPrice_Int()
    {
      Bread bread = new Bread(1);
      Pastry pastry = new Pastry(1);
      bread.GetTotalPrice();
      pastry.GetTotalPrice();
      Assert.AreEqual(7, Cart.GetTotalPrice(bread.TotalPrice, pastry.TotalPrice));
    }
  }
}