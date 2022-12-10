using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class CartTest
  {
    [TestMethod]
    public void AddTotalBread_AddOneCountOfBread_Int()
    {
      int count = 2;
      Assert.AreEqual(2, Cart.AddTotalBread(count));
    }
    [TestMethod]
    public void AddTotalPastry_AddOneCountOfPastry_Int()
    {
      int count = 2;
      Assert.AreEqual(2, Cart.AddTotalPastry(count));
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