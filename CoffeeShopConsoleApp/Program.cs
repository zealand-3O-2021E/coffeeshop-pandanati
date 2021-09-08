using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(),
                new BlackCoffee(),
                new Cortado()

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Price of the coffee is : {coffee.price()} - - - Strength: {coffee.strength()}\n" +
                    $"Amount of milk in ml ");
            }


        }
    }
}
