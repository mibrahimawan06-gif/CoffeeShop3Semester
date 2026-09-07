// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

BlackCoffee blackCoffee = new BlackCoffee(2);
Latte latte = new Latte(5);
Cortado cortado = new Cortado(3);

List<Coffee> coffeeList = new List<Coffee> { blackCoffee, latte, cortado };

foreach (Coffee coffee in coffeeList)
{
    Console.WriteLine("Price: " + coffee.Price());
    Console.WriteLine("Strength:" + coffee.Strength());
    Console.WriteLine();

}

