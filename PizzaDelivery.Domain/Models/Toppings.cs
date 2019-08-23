using System;

namespace PizzaDelivery.Domain.Models
{
    public class Toppings
    {
      
      public string toppings;
      public Toppings(string toppings)
       {
         this.PizzaToppings = toppings;
       }

      public string PizzaToppings { 
      
      get
      { 
        return this.toppings; 
      } 
      set
      {  
        if(value.ToLower() == "cheese" || value.ToLower() == "bacon" || value.ToLower() == "pepperoni" || value.ToLower() == "sausage" || value.ToLower() == "veggie" || value.ToLower() == "pineapple")
        {
          this.toppings = value;
        }else{
          throw new ArgumentException("We currently do not offer {0} as toppings", value);
        }
        
        

      } 
      
      }

      
    }
}
