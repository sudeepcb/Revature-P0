using System.Collections.Generic;

namespace PizzaDelivery.Domain.Models
{
    public class Users
    {
      //public int UsersID { get; set; }
      public string Name {get; set;}

      public List<Order> Orders { get; private set; }

      public Users(string userName)
      {
        this.Name = userName;
      }  
    }
}
