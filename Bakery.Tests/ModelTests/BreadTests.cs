using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
    }
    [TestMethod]
    public void GetTotalPrice_PriceForOneBread_Int()
    {
      Bread bread = new Bread(1);
      bread.GetTotalPrice();
      Assert.AreEqual(5, bread.TotalPrice);
    }
    [TestMethod]
    public void GetTotalPrice_PriceForTwoBread_Int()
    {
      Bread bread = new Bread(2);
      bread.GetTotalPrice();
      Assert.AreEqual(10, bread.TotalPrice);
    }
    [TestMethod]
    public void GetTotalPrice_PriceForThreeBread_Int()
    {
      Bread bread = new Bread(3);
      bread.GetTotalPrice();
      Assert.AreEqual(10, bread.TotalPrice);
    }
    [TestMethod]
    public void GetTotalPrice_PriceForFourBread_Int()
    {
      Bread bread = new Bread(4);
      bread.GetTotalPrice();
      Assert.AreEqual(15, bread.TotalPrice);
    }
  }
}