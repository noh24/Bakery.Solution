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
    bool doneWithOrder = false;
    while (!doneWithOrder)
    {
      string userInput = PromptOrder();
      if (userInput.Contains("bread"))
      {
        bool validNumber = false;
        while (!validNumber)
        {
          try 
          {
            int breadQuantity = PromptBreadOrder();
            Cart.AddTotalBread(breadQuantity);
            validNumber = true;
          }
          catch (Exception)
          {
            Console.WriteLine("Invalid Entry. Please enter a valid number.");
          }
        }
        bool isThereMore = false;
        while (!isThereMore)
        {
          string anythingElse = AnythingElse();
          if (anythingElse == "y")
          {
            isThereMore = true;
            continue;
          }
          else if (anythingElse == "n")
          {
            Checkout();
            isThereMore = true;
            doneWithOrder = true;
          }
          else
          {
            Console.WriteLine("Invalid Entry. Enter 'y' for yes or 'n' for no.");
          }
        }
      }
      else if (userInput.Contains("pastry"))
      {
        bool validNumber = false;
        while (!validNumber)
        {
          try 
          {
            int pastryQuantity = PromptPastryOrder();
            Cart.AddTotalPastry(pastryQuantity);
            validNumber = true;
          }
          catch (Exception)
          {
            Console.WriteLine("Invalid Entry. Please enter a valid number.");
          }
        }
        bool isThereMore = false;
        while (!isThereMore)
        {
          string anythingElse = AnythingElse();
          if (anythingElse == "y")
          {
            isThereMore = true;
            continue;
          }
          else if (anythingElse == "n")
          {
            Checkout();
            isThereMore = true;
            doneWithOrder = true;
          }
          else
          {
            Console.WriteLine("Invalid Entry. Enter 'y' for yes or 'n' for no.");
          }
        }
      }
      else
      {
        Console.WriteLine("Invalid Entry. Please enter 'bread' for bread or 'pastry' for pastry.");
      }
    }
  }
  public static string PromptOrder()
  {
    Console.WriteLine("Would you like to order bread or pastry? [bread/pastry]");
    string userInput = Console.ReadLine().ToLower();
    return userInput;
  }
  public static int PromptBreadOrder()
  {
    Console.WriteLine("How many loaves of bread would you like to order? [Enter a numerical value]");
    int userBreadQuantity = Convert.ToInt32(Console.ReadLine());
    return userBreadQuantity;
  }
  public static int PromptPastryOrder()
  {
    Console.WriteLine("How many pastries would you like to order? [Enter a numerical value]");
    int userPastryQuantity = Convert.ToInt32(Console.ReadLine());
    return userPastryQuantity;
  }
  public static string AnythingElse()
  {
    Console.WriteLine("Is there anything else? [Y/N]");
    string userInput = Console.ReadLine().ToLower();
    return userInput;
  }
  public static void Checkout()
  {
    Bread bread = new Bread(Cart.TotalBread);
    bread.GetTotalPrice();
    Pastry pastry = new Pastry(Cart.TotalPastry);
    pastry.GetTotalPrice();
    Console.WriteLine("This is your order: \n{0} Bread. \n{1} Pastry. \nTotal is ${2}.", Cart.TotalBread, Cart.TotalPastry, Cart.GetTotalPrice(bread.TotalPrice, pastry.TotalPrice));
  }
}
