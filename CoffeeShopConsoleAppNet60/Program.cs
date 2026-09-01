// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee();
Latte latte = new Latte();
Cortado cortado = new Cortado();

List<Coffee> coffeeList = new List<Coffee> { blackCoffee, latte, cortado };

foreach (Coffee coffee in coffeeList)
{
    Console.WriteLine("Price: " + coffee.Price());
    Console.WriteLine("Strength:" + coffee.Strength());
    Console.WriteLine();

}

