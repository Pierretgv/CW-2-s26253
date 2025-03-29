namespace ContainerManagement.Transport
{
    public class Truck : TransportVehicle
    {
        public double MaxRange { get; }

        public Truck(int maxContainers, double maxWeight, double maxRange)
            : base(maxContainers, maxWeight)
        {
            MaxRange = maxRange;
        }

        /// <summary>
        /// Sprawdza, czy ciężarówka może pokonać trasę.
        /// </summary>
        public void CheckFuelEfficiency(double distance)
        {
            if (distance > MaxRange)
                Console.WriteLine($"Uwaga! Dystans {distance} km przekracza zasięg ciężarówki ({MaxRange} km). Konieczny postój na tankowanie.");
            else
                Console.WriteLine($"Trasa {distance} km jest w zasięgu ciężarówki. Można ruszać!");
        }

        public override string ToString() =>
            $"Ciężarówka przewozi {Containers.Count}/{MaxContainers} kontenerów. Całkowita masa: {GetTotalWeight()} kg, Maksymalny zasięg: {MaxRange} km.";
    }
}