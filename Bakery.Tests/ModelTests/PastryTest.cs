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
      Assert.AreEqual(2, pastry.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForTwoPastry_Int()
    {
      Pastry pastry = new Pastry(2);
      Assert.AreEqual(4, pastry.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForThreePastry_Int()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(5, pastry.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForFourPastry_Int()
    {
      Pastry pastry = new Pastry(4);
      Assert.AreEqual(7, pastry.GetTotalPrice());
    }
  }
}