using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void BreadConstructor_BreadInheritPropertyFromAbstractClass_PropertyValues()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(1, bread.Count);
      Assert.AreEqual(0, bread.TotalPrice);
      Assert.AreEqual(5, bread.PricePerUnit);
    }
    [TestMethod]
    public void GetTotalPrice_PriceForOneBread_Int()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(5, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForTwoBread_Int()
    {
      Bread bread = new Bread(2);
      Assert.AreEqual(10, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForThreeBread_Int()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(10, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForFourBread_Int()
    {
      Bread bread = new Bread(4);
      Assert.AreEqual(15, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForFiveBread_Int()
    {
      Bread bread = new Bread(5);
      Assert.AreEqual(20, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForSixBread_Int()
    {
      Bread bread = new Bread(6);
      Assert.AreEqual(20, bread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForZeroBread_Int()
    {
      Bread bread = new Bread(0);
      Assert.AreEqual(0, bread.GetTotalPrice());
      Assert.AreEqual(0, bread.Count);
    }

  }
}