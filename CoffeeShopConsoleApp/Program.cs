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
                new Latte(0),
                new BlackCoffee(0),
                new Cortado(5),
                new FlatWhite(0)

            };
            List<IMilk> milkList = new List<IMilk>();

            //Cortado coffeewithtoomuchdiscount = new Cortado(6);
            Cortado cortadowith5discount = new Cortado(5);

            foreach (var coffee in orderList)
            {
                Console.WriteLine($"the Price of the coffee is : {coffee.price()} - - - Strength: {coffee.strength()}");

                if (coffee is IMilk)
                {
                    milkList.Add(coffee as IMilk);
                }
            }

            Console.WriteLine($"\n Milk list has a total of {milkList.Count} coffees");

        }
    }
}
