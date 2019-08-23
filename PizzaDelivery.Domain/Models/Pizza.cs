using System.Collections.Generic;

namespace PizzaDelivery.Domain.Models
{
  public class Pizza
  {

    public Crust crustType  { get; private set; }
    public Size pizzaSize { get; private set; }
    public List<Toppings> Toppings { get; set; }

    public double totalCost { get; private set; }
    public Pizza(Crust crust, Size size, List<Toppings> toppings)
    {
 
      this.pizzaSize = size;
      this.crustType = crust;
      if(toppings.Count > 5 || toppings.Count < 2)
      {
        System.Console.WriteLine("Gotta put more than 2 toppings and less than 6 toppings!");
      }
      else
      {
        this.Toppings = toppings;
      }
      }
    }
  }
