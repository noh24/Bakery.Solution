using System;
using Bakery.Models;
public class Program
{
  public static void Main()
  {
    // welcome customer
    // cost for bread and pastry
    // customer how many of each
    // return total price
      // offer deals bread 1 = 5, 2 = 10, 3 = 10
      // pastry : buy 1 = 2,  deal 3 = 5, 4 = 7, 5 = 9, 6 = 10 

    Console.WriteLine("Welcome to Pierre's Bakery");
    Console.WriteLine("==========================");
    Console.WriteLine("Menu *Holiday Special*");
    Console.WriteLine("==========================");
    Console.WriteLine("Bread: $5 \nBuy Two, Get One Free!\n");
    Console.WriteLine("Pastry: $2 \nBuy Two, Get One 50% Off!");
    Console.WriteLine("==========================");
    PromptOrder();
  }
  public static void PromptOrder()
  {
    Console.WriteLine("Would you like to order Bread or Pastry? [bread/pastry]");
    string userInput = Console.ReadLine().ToLower();
    bool doneWithOrder = false;
    while (!doneWithOrder)
    {
      if (userInput.Contains("bread"))
      {
        Console.WriteLine("How many loaves of bread would you like to order? [Enter a numerical value]");
        try
        {
          int userBreadQuantity = Convert.ToInt32(Console.ReadLine());
          Cart.AddTotalBread(userBreadQuantity);
        }
        catch (Exception)
        {
          Console.WriteLine("Invalid entry. Please enter a numerical value. \n");
        }
        bool areYouDone = false;
        while (!areYouDone)
        {
          Console.WriteLine("Is there anything else? [Y/N]");
          string anythingElse = Console.ReadLine().ToLower();
          if (anythingElse == "n")
          { 
            Bread bread = new Bread(Cart.TotalBread);
            bread.GetTotalPrice();
            Pastry pastry = new Pastry(Cart.TotalPastry);
            pastry.GetTotalPrice();
            Console.WriteLine("This is your order: \n{0} Bread. \n{1} Pastry. \nTotal is ${2}.", Cart.TotalBread, Cart.TotalPastry, Cart.GetTotalPrice(bread.TotalPrice, pastry.TotalPrice));
            doneWithOrder = true;
            areYouDone = true;
          }
          else if (anythingElse != "n" || anythingElse != "y")
          {
            Console.WriteLine("Invalid entry.");
          }
        }
      }
      else if (userInput.Contains("pastry"))
      {
        Console.WriteLine("How many pastries would you like to order? [Enter a numerical value]");
        try
        {
          int userPastryQuantity = Convert.ToInt32(Console.ReadLine());
          Cart.AddTotalPastry(userPastryQuantity);
        }
        catch (Exception)
        {
          Console.WriteLine("Invalid entry. Please enter a numerical value. \n");
          PromptOrder();
        }
        Console.WriteLine("Is there anything else? [Y/N]");
        string anythingElse = Console.ReadLine().ToLower();
        if (anythingElse == "y")
        {
          PromptOrder();
        }
        else if (anythingElse == "n")
        {
          Bread bread = new Bread(Cart.TotalBread);
          bread.GetTotalPrice();
          Pastry pastry = new Pastry(Cart.TotalPastry);
          pastry.GetTotalPrice();
          Console.WriteLine("This is your order: \n{0} Bread. \n{1} Pastry. \nTotal is ${2}.", Cart.TotalBread, Cart.TotalPastry, Cart.GetTotalPrice(bread.TotalPrice, pastry.TotalPrice));
          doneWithOrder = true;
        }
      }
    }
  }
}