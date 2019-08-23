using System;

namespace PizzaDelivery.Domain.Models
{
    public class Size
    {
      
      public string size;
      public Size(string size)
       {
         this.PizzaSize = size;
       }

      public string PizzaSize { 
      
      get
      { 
        return this.size; 
      } 
      set
      {  
        if(value.ToLower() == "small" || value.ToLower() == "medium" || value.ToLower() == "large" || value.ToLower() == "xlarge")
        {
          this.size = value;
        }else{
          throw new ArgumentException("We currently do not offer {0} as size", value);
          
        }
        
        

      } 
      
      }

      
    }
}