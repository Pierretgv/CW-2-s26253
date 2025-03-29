using ContainerManagement.Containers;

namespace ContainerManagement.Transport
{
    public abstract class TransportVehicle
    {
        public List<Container> Containers { get; } = new();
        public int MaxContainers { get; }
        public double MaxWeight { get; }

        protected TransportVehicle(int maxContainers, double maxWeight)
        {
            MaxContainers = maxContainers;
            MaxWeight = maxWeight;
        }

        public virtual void LoadContainer(Container container)
        {
            if (Containers.Count >= MaxContainers || GetTotalWeight() + container.OwnWeight > MaxWeight * 1000)
                throw new Exception($"Nie można załadować {container.SerialNumber}, przekroczono limity wagowe ({MaxWeight} kg).");
            Containers.Add(container);
        }

        public void UnloadContainer(Container container)
        {
            if (Containers.Remove(container))
                Console.WriteLine($"Kontener {container.SerialNumber} został rozładowany.");
        }

        public double GetTotalWeight()
        {
            double total = 0;
            foreach (var container in Containers)
            {
                total += container.LoadWeight + container.OwnWeight;
            }
            return total;
        }

        public override string ToString() =>
            $"Pojazd przewozi {Containers.Count}/{MaxContainers} kontenerów, całkowita masa: {GetTotalWeight()} kg";
    }
}