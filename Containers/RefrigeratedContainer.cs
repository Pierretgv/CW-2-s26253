using System;
using System.Collections.Generic;

namespace ContainerManagement.Containers
{
    public class RefrigeratedContainer : Container
    {
        public string ProductType { get; }
        public double Temperature { get; }
        
        private static readonly Dictionary<string, double> ProductTemperatures = new()
        {
            { "Banany", 13 },
            { "Jabłka", 1 },
            { "Mleko", 4 },
            { "Wołowina", -2 },
            { "Ryby", -18 },
            { "Lody", -20 },
            { "Szczepionki", -70 },
            { "Ser", 3 },
            { "Warzywa", 5 },
            { "Czekolada", 18 }
        };

        public RefrigeratedContainer(double maxCapacity, double height, double ownWeight, double depth, string productType, double temperature)
            : base(maxCapacity, height, ownWeight, depth, "C")
        {
            if (!ProductTemperatures.ContainsKey(productType))
                throw new ArgumentException($"Nieobsługiwany produkt: {productType}");

            if (temperature > ProductTemperatures[productType])
                throw new ArgumentException($"Temperatura dla {productType} nie może być wyższa niż {ProductTemperatures[productType]}°C!");

            ProductType = productType;
            Temperature = temperature;
        }

        public override string ToString()
        {
            return $"[{SerialNumber}] Produkt: {ProductType}, Temperatura: {Temperature}°C, Waga ładunku: {LoadWeight}/{MaxCapacity} kg";
        }
        
        public static void PrintProductTable()
        {
            Console.WriteLine("Lista obsługiwanych produktów chłodniczych:");
            Console.WriteLine("+----------------+----------------------+");
            Console.WriteLine("| Produkt       | Minimalna temp. (°C)  |");
            Console.WriteLine("+----------------+----------------------+");

            foreach (var product in ProductTemperatures)
            {
                Console.WriteLine($"| {product.Key,-12} | {product.Value,18}°C |");
            }

            Console.WriteLine("+----------------+----------------------+");
        }
    }
}