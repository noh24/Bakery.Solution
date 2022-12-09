using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price {get; set;}
    public int Quantity {get; set;}
    public Bread(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }
  }
}