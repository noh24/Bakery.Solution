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
  }
}