using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void GetTotalPrice_PriceForOnePastry_Int()
    {
      Pastry pastry = new Pastry(1);
      pastry.GetTotalPrice();
      Assert.AreEqual(2, pastry.TotalPrice);
    }
    [TestMethod]
    public void GetTotalPrice_PriceForTwoPastry_Int()
    {
      Pastry pastry = new Pastry(2);
      pastry.GetTotalPrice();
      Assert.AreEqual(4, pastry.TotalPrice);
    }
  }
}