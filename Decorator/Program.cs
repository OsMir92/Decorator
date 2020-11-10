using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            PrintBeverageCost(beverage);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            PrintBeverageCost(beverage2);

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            PrintBeverageCost(beverage3);

            Beverage beverage4 = new Decaf();
            beverage4 = new Latte(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            PrintBeverageCost(beverage4);

            Console.ReadLine();
        }

        private static void PrintBeverageCost(Beverage beverage)
        {
            Console.WriteLine($"{beverage.description} ${beverage.Cost()}");
        }
    }
    
}
