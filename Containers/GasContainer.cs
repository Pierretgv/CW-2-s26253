using ContainerManagement.Interfaces;

namespace ContainerManagement.Containers
{
    public class GasContainer : Container, IHazardNotifier
    {
        public double Pressure { get; }

        public GasContainer(double maxCapacity, double height, double ownWeight, double depth, double pressure)
            : base(maxCapacity, height, ownWeight, depth, "G")
        {
            Pressure = pressure;
        }

        public override void Unload() => LoadWeight *= 0.05;

        public void NotifyHazard(string message) => Console.WriteLine($"[ALERT] {SerialNumber}: {message}");
    }
}