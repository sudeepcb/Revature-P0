using System;

namespace PizzaDelivery.Domain.Models
{
    public class Crust
    {
      public string crustType;

        
       public Crust(string crust)
       {
         this.CrustType = crust;
       }

      public string CrustType { 
      
      get
      { 
        return this.crustType; 
      } 
      set
      {
        if(value.ToLower() == "thin" || value.ToLower() == "pan" || value.ToLower() == "thick")
        {
          this.crustType = value;
        }else{
          throw new ArgumentException("We currently do not offer {0} as a crust", value);  
        }
        

      } 
      
      }


  }
}