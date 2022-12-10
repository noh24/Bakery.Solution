using System;

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
    Console.WriteLine("Would you like to order Bread or Pastry? [bread/pastry]");
    string userInput = Console.ReadLine().ToLower();
    bool DoneWithOrder = false;
    PromptOrder(userInput, DoneWithOrder);
  }
  public static void PromptOrder(string userInput, bool doneWithOrder)
  {
    while (!doneWithOrder)
    {
      if (userInput.Contains("bread"))
      {
        Console.WriteLine("How many loaves of bread would you like to order? [Enter a numerical value]");
        try
        {
          int userBreadQuantity = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Invalid entry. Please enter a numerical value. \n");
          PromptOrder(userInput, doneWithOrder);
        }
      }
      else if (userInput.Contains("pastry"))
      {
        Console.WriteLine("How many pastries would you like to order? [Enter a numerical value]");
        try
        {
          int userPastryQuantity = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Invalid entry. Please enter a numerical value. \n");
          PromptOrder(userInput, doneWithOrder);
        }
      }
    }
  }
  public static void PromptAnotherOrder()
  {
    
  }
}
