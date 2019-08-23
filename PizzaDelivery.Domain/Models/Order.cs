using System.Collections.Generic;

namespace PizzaDelivery.Domain.Models
{
  public class Order
  {

    //public int orderId { get; private set; }

    public double totalCost { get; private set; }
    public Users myUser { get; set; }
    public Location myLocation { get; set; }
    public Pizza MakeOrder(Users myUser, Location myLocation)
    {
      myLocation.addUser(myUser.Name);
      System.Console.WriteLine("Making Order for {0}, in Location {1}", myUser.Name, myLocation.locationName);
      System.Console.WriteLine("What type of crust [thin] [thick] [pan]?");
      string crust = System.Console.ReadLine();
      crust = crust.Replace(" ", "");
      var c = new Crust(crust);
      System.Console.WriteLine("What size pizza [small] [medium] [large] [xlarge]?");
      string size = System.Console.ReadLine();
      size = size.Replace(" ", "");
      var s = new Size(size);
      if (size.Equals("small"))
      {
        totalCost += 9.00;
      }
      if (size.Equals("medium"))
      {
        totalCost += 11.00;
      }
      if (size.Equals("large"))
      {
        totalCost += 13.00;
      }
      if (size.Equals("xlarge"))
      {
        totalCost += 15.00;
      }
      System.Console.WriteLine("What toppings for the pizza [cheese] [bacon] [sausage] [veggie] [pepperoni] [pineapple]?");
      List<Toppings> toppings = new List<Toppings>();
      string[] totalToppings = new string[10];
      string input = null;
      while ((input = System.Console.ReadLine()) != string.Empty)
      {
        input = input.Replace(" ", "");
        Toppings allToppings = new Toppings(input);
        toppings.Add(allToppings);
        totalCost += 0.50;

      }
      if (toppings.Count < 2 || toppings.Count > 5)
      {
        return new Pizza(c, s, toppings);
      }
      System.Console.WriteLine("How many of the custom {0} pizza, would you like? (limit is 100)", size);
      int intTemp = System.Convert.ToInt32(System.Console.ReadLine());
      if(intTemp < 101)
      {
      totalCost = intTemp * totalCost;
      }
      else
      {
        throw new System.ArgumentOutOfRangeException("Cannot have more than 100 pizzas at once!");
      }
      if (totalCost < 5000)
      {
        System.Console.Write("Thanks for your order of custom {0} pizza with {1} crust and Toppings:", size, crust);
        foreach (var item in toppings)
        {
          System.Console.Write(" ");
          System.Console.Write(item.PizzaToppings);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Your Total is $ {0} ", totalCost);
      }
      else
      {
        throw new System.SystemException("Cannot have total over $5000, sorry!");
      }
      return new Pizza(c, s, toppings);
    }
    public Order(Users users, Location location)
    {
      MakeOrder(users, location);
    }
  }

}