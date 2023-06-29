using System;

class CofffeeMachine
{
    private int waterLevel;
    private int coffeeBeansLevel;
    private int milkLevel;

    public CofffeeMachine()
    {
        waterLevel = 0;
        coffeeBeansLevel = 0;
        milkLevel = 0;
    }

    public void AddWater(int amount)
    {
        waterLevel += amount;
        Console.WriteLine($"Added {amount} ml of water. Current water level: {waterLevel} ml");
    }

    public void AddCoffeeBeans(int amount)
    {
        coffeeBeansLevel += amount;
        Console.WriteLine($"Added {amount} g of coffee beans. Current coffee bean level: {coffeeBeansLevel} g");
    }

    public void AddMilk(int amount)
    {
        milkLevel += amount;
        Console.WriteLine($"Added {amount} ml of milk. Current milk level: {milkLevel} ml");
    }

    public void MakeEspresso()
    {
        if (waterLevel >= 30 && coffeeBeansLevel >= 10)
        {
            waterLevel -= 30;
            coffeeBeansLevel -= 10;
            Console.WriteLine("Espresso require 30ml water and 10g coffee beans! Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Making Espresso...");
            Thread.Sleep(10000);
            Console.WriteLine("Enjoy your drink!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Not enough water or coffee beans. Please refill.");
        }
    }

    public void MakeCappucino()
    {
        if (waterLevel >= 60 && coffeeBeansLevel >= 20 && milkLevel >= 50)
        {
            waterLevel -= 60;
            coffeeBeansLevel -= 20;
            milkLevel -= 50;
            Console.WriteLine("Cappucino require 60ml water and 20g coffee beans! Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Making Cappuccino...");
            Thread.Sleep(10000);
            Console.WriteLine("Enjoy your drink!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Not enough water, coffee beans, or milk. Please refill.");
        }
    }

    public void CheckLevels()
    {
        Console.WriteLine($"Water level: {waterLevel} ml");
        Console.WriteLine($"Coffee beans level: {coffeeBeansLevel} g");
        Console.WriteLine($"Milk level: {milkLevel} ml");
    }
}