using CoffeeShopConsoleAppNet60;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class CoffeeTests
{
    [Fact]
    public void BlackCoffee_Price_Is20()
    {
        BlackCoffee coffee = new BlackCoffee(0);

        int result = coffee.Price();

        Assert.Equal(20, result);
    }

    [Fact]
    public void Cortado_Price_Is25()
    {
        Cortado coffee = new Cortado(0);

        int result = coffee.Price();

        Assert.Equal(25, result);
    }

    [Fact]
    public void Latte_Price_Is40()
    {
        Latte coffee = new Latte(0);

        int result = coffee.Price();

        Assert.Equal(40, result);
    }
}