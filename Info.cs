using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking the hotel?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probalby going to expensive. Your stay is both peak season and the weekend.");
    }
    else if (summer || weekend)
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("Your stay will likely be the cheapest possible!");
    }
    else
    {
      Console.WriteLine("Your stay might be expensive, but it could be worse!");
    }
  }
}
