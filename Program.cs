using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        CofffeeMachine machine = new CofffeeMachine();
        
        machine.AddWater(200);
        
        machine.AddCoffeeBeans(50);
        
        machine.AddMilk(100);
        
        machine.CheckLevels();

        Console.WriteLine("");
        Console.WriteLine("Espresso: 1 - Cappucino: 2");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            machine.MakeEspresso();
        }
        else
        {
            machine.MakeCappucino();
        }
    }
}