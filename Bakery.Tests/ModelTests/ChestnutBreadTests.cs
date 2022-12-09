using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class ChestnutBreadTests
  {
    [TestMethod]
    public void GetTotalPrice_PriceForOneChestnutBread_Int()
    {
      ChestnutBread chestnutBread = new ChestnutBread(1);
      Assert.AreEqual(7, chestnutBread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForTwoChestnutBread_Int()
    {
      ChestnutBread chestnutBread = new ChestnutBread(2);
      Assert.AreEqual(14, chestnutBread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForThreeChestnutBread_Int()
    {
      ChestnutBread chestnutBread = new ChestnutBread(3);
      Assert.AreEqual(16, chestnutBread.GetTotalPrice());
    }
    [TestMethod]
    public void GetTotalPrice_PriceForSixChestnutBread_Int()
    {
      ChestnutBread chestnutBread = new ChestnutBread(6);
      Assert.AreEqual(32, chestnutBread.GetTotalPrice());
    }
  }
}