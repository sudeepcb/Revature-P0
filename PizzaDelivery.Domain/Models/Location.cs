using System.Collections.Generic;
using System.Linq;

namespace PizzaDelivery.Domain.Models
{
  public class Location
  {
    //public int locationID { get; set; }
    public string locationName { get; set; }
    public List<Order> Orders { get; private set; }

    public List<Users> allUsers { get; set; } 

    public void addLocation(string newLocation)
    {
      new Location(locationName);
    }

    public void addUser(string name)
    {
      allUsers = new List<Users>();
      //System.Console.WriteLine("we entered");
      allUsers.Add(new Users("sudeep"));
      allUsers.Add(new Users("billy"));
      allUsers.Add(new Users("billy"));
      allUsers.Add(new Users("billy"));
      allUsers.Add(new Users("billy"));
      allUsers.Add(new Users("billy"));
      allUsers.Add(new Users("billy"));
      //System.Console.WriteLine("we got here");
      foreach (var user in allUsers.ToList())
      {
        if (user.Name == name)
        {
          System.Console.WriteLine("AYYYY, U BACK!");
          break;
        }
        else
        {
          //System.Console.WriteLine("Pleasure to add you to the location!");
          allUsers.Add(new Users(name));
          System.Console.WriteLine("We added you");
          break;
        }
      }
    }

    public void getAllUsers(Location location)
    {
      if (allUsers == null)
      {
        System.Console.WriteLine("We lonely out here");
      }
      else
      {
        int i = 0;
        foreach (var v in allUsers)
        {
          System.Console.WriteLine("User {0}", i);
          i++;
        }
      }
    }

    public void getAllOrders(Location location)
    {
      if (Orders == null)
      {
        System.Console.WriteLine("We lonely out here");
      }
      else
      {
        int i = 0;
        foreach (var v in Orders)
        {
          System.Console.WriteLine("Order {0}", i);
          i++;
        }
      }
    }




    public Location(string location)
    {
      this.locationName = location;
    }
  }
}