using System;
using System.Collections.Generic;
using ContainerManagement.Containers;
using ContainerManagement.Transport;

class Program
{
    static void Main()
    {
        RefrigeratedContainer.PrintProductTable();

        var ship = new Ship(18, 200000, 30);

        var container1 = new RefrigeratedContainer(1000, 250, 500, 600, "Banany", 13);
        var container2 = new RefrigeratedContainer(1000, 250, 500, 600, "Jabłka", 1);
        var container3 = new RefrigeratedContainer(1000, 250, 500, 600, "Mleko", 4);
        var container4 = new RefrigeratedContainer(1000, 250, 500, 600, "Wołowina", -2);
        var container5 = new RefrigeratedContainer(1000, 250, 500, 600, "Ryby", -18);
        var container6 = new RefrigeratedContainer(1000, 250, 500, 600, "Lody", -20);
        var container7 = new RefrigeratedContainer(1000, 250, 500, 600, "Szczepionki", -70);
        var container8 = new RefrigeratedContainer(1000, 250, 500, 600, "Ser", 3);
        var container9 = new RefrigeratedContainer(1000, 250, 500, 600, "Warzywa", 5);
        var container10 = new RefrigeratedContainer(1000, 250, 500, 600, "Czekolada", 18);

        var liquidContainer1 = new LiquidContainer(1000, 250, 500, 600, false);
        var liquidContainer2 = new LiquidContainer(1000, 250, 500, 600, true);

        var gasContainer1 = new GasContainer(500, 200, 300, 500, 5);
        var gasContainer2 = new GasContainer(500, 200, 300, 500, 8);

        ship.LoadContainer(container1);
        ship.LoadContainer(container2);
        ship.LoadContainer(container3);
        ship.LoadContainer(container4);
        ship.LoadContainer(container5);
        ship.LoadContainer(container6);
        ship.LoadContainer(container7);
        ship.LoadContainer(container8);
        ship.LoadContainer(container9);
        ship.LoadContainer(container10);
        ship.LoadContainer(liquidContainer1);
        ship.LoadContainer(liquidContainer2);
        ship.LoadContainer(gasContainer1);
        ship.LoadContainer(gasContainer2);

        Console.WriteLine(ship);
    }
}