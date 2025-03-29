using ContainerManagement.Containers;
using ContainerManagement.Transport;

{
    static void Main()
    {
        // Tworzenie statku
        var ship = new Ship(10, 200, 30);

        // Tworzenie kontenerów zgodnie z tabelą
        var bananaContainer = new RefrigeratedContainer(1000, 250, 500, 600, "Bananas", 13.3);
        var fishContainer = new RefrigeratedContainer(1000, 250, 500, 600, "Fish", 2);
        var iceCreamContainer = new RefrigeratedContainer(1000, 250, 500, 600, "Ice cream", -18);
        
        // Tworzenie kontenera na gaz
        var gasContainer = new GasContainer(500, 200, 300, 500, 5);

        // Tworzenie kontenera na płyny (bezpieczny)
        var milkContainer = new LiquidContainer(1000, 250, 500, 600, false);
        
        // Załadunek kontenerów na statek
        ship.LoadContainer(bananaContainer);
        ship.LoadContainer(fishContainer);
        ship.LoadContainer(iceCreamContainer);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(milkContainer);

        // Wypisanie informacji o statku i jego ładunku
        ship.PrintCargoDetails();

        // Sprawdzenie przeciążenia
        Console.WriteLine(ship.IsOverloaded() ? "Statek jest przeciążony!" : "Statek gotowy do rejsu.");
    }
}
Console.WriteLine("Hello, World!");
