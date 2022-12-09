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
    public void BreadConstructor_InstanceOfBreadWithProperties_PropertyValues()
    {
      int price = 5;
      int quantity = 1;
      Bread bread = new Bread(price, quantity);
      Assert.AreEqual(price, bread.Price);
      Assert.AreEqual(quantity, bread.Quantity);
    }
  }
}