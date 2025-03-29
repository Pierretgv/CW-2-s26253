using ContainerManagement.Containers;
using ContainerManagement.Transport;
class Program
{
    static void Main()
    {
        var ship = new Ship(10, 200, 30);

        var bananaContainer = new RefrigeratedContainer(1000, 250, 500, 600, "Bananas", 13.3);
        var gasContainer = new GasContainer(500, 200, 300, 500, 5);
        var milkContainer = new LiquidContainer(1000, 250, 500, 600, false);
        
        bananaContainer.Load(900); 
        gasContainer.Load(450);      
        milkContainer.Load(500);  
        
        ship.LoadContainer(bananaContainer);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(milkContainer);
        
        ship.PrintCargoDetails();

        
        Console.WriteLine(ship.IsOverloaded() ? "Statek jest przeciążony!" : "Statek gotowy do rejsu.");

        Console.WriteLine("Naciśnij Enter, aby zamknąć...");
        Console.ReadLine();
    }
}
