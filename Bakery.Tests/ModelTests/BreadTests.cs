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
      Bread bread = new Bread(1, 5);
      Assert.AreEqual(1, bread.Count);
      Assert.AreEqual(5, bread.TotalPrice);
    }
  }
}