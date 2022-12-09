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
      for (int i = 1; i <= Count; i++)
      {
        if (i % 3 == 0)
        {
          TotalPrice += 0;
        }
        else
        {
          TotalPrice += 5;
        }
      }
      return TotalPrice;
    }
  }
}