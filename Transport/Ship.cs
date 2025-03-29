using ContainerManagement.Containers;

namespace ContainerManagement.Transport
{
    public class Ship
    {
        public List<Container> Containers { get; } = new();
        public int MaxContainers { get; }
        public double MaxWeight { get; }
        public double MaxSpeed { get; } 

        public Ship(int maxContainers, double maxWeight, double maxSpeed)
        {
            MaxContainers = maxContainers;
            MaxWeight = maxWeight;
            MaxSpeed = maxSpeed;
        }

        public void LoadContainer(Container container)
        {
            if (Containers.Count >= MaxContainers)
                throw new Exception($"Statek nie może przewozić więcej niż {MaxContainers} kontenerów.");
            
            if (GetTotalWeight() + container.LoadWeight + container.OwnWeight > MaxWeight * 1000)
                throw new Exception("Przekroczono maksymalną ładowność statku.");

            Containers.Add(container);
        }

        public void RemoveContainer(string serialNumber)
        {
            var container = Containers.Find(c => c.SerialNumber == serialNumber);
            if (container != null)
                Containers.Remove(container);
        }

        public double GetTotalWeight()
        {
            double totalWeight = 0;
            foreach (var container in Containers)
            {
                totalWeight += container.LoadWeight + container.OwnWeight;
            }
            return totalWeight;
        }

        public void PrintCargoDetails()
        {
            Console.WriteLine($"Statek przewozi {Containers.Count}/{MaxContainers} kontenerów.");
            Console.WriteLine($"Całkowita masa ładunku: {GetTotalWeight()} kg (max: {MaxWeight * 1000} kg)");
            Console.WriteLine($"Maksymalna prędkość: {MaxSpeed} węzłów");

            foreach (var container in Containers)
            {
                Console.WriteLine(container);
            }
        }

        public bool IsOverloaded()
        {
            return GetTotalWeight() > MaxWeight * 1000;
        }

        public override string ToString()
        {
            return $"Statek: {Containers.Count}/{MaxContainers} kontenerów, Masa: {GetTotalWeight()} kg, Prędkość: {MaxSpeed} węzłów";
        }
    }
}
