using ContainerManagement.Exceptions;

namespace ContainerManagement.Containers
{
    public abstract class Container
    {
        private static int _counter = 1;
        public string SerialNumber { get; }
        public double LoadWeight { get; protected set; }
        public double MaxCapacity { get; }
        public double Height { get; }
        public double OwnWeight { get; }
        public double Depth { get; }

        protected Container(double maxCapacity, double height, double ownWeight, double depth, string type)
        {
            MaxCapacity = maxCapacity;
            Height = height;
            OwnWeight = ownWeight;
            Depth = depth;
            SerialNumber = $"KON-{type}-{_counter++}";
        }

        public virtual void Load(double weight)
        {
            if (LoadWeight + weight > MaxCapacity)
                throw new OverfillException($"Przekroczono maksymalną pojemność kontenera {SerialNumber}.");
            LoadWeight += weight;
        }

        public virtual void Unload() => LoadWeight = 0;

        public override string ToString() => $"[{SerialNumber}] Waga ładunku: {LoadWeight}/{MaxCapacity} kg";
    }
}