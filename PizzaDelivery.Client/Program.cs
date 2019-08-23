using System;
using PizzaDelivery.Domain.Models;

namespace PizzaDelivery.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Tell me ur name!");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Which location do u want to order from?");
            // find locations helper
            string location = System.Console.ReadLine();
            var l = new Location(location);
            var u = new Users(name);
            var o = new Order(u, l);
        }
    }
}
