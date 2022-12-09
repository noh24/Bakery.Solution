using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : Cart
  {
    public Bread(int count) : base(count)
    {
    }
    public override int GetTotalPrice()
    {
      if (Count >= 3)
      {
        return TotalPrice = (Count - 1) * 5;
      }
      return TotalPrice = Count * 5;
    }
    // public int Price {get; set;}
    // public int Quantity {get; set;}
    // public Bread(int price, int quantity)
    // {
    //   Price = price;
    //   Quantity = quantity;
    // }
  }
}