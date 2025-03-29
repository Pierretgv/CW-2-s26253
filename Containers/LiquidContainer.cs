using ContainerManagement.Exceptions;
using ContainerManagement.Interfaces;

namespace ContainerManagement.Containers
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        private bool _isHazardous;

        public LiquidContainer(double maxCapacity, double height, double ownWeight, double depth, bool isHazardous)
            : base(maxCapacity, height, ownWeight, depth, "L")
        {
            _isHazardous = isHazardous;
        }

        public override void Load(double weight)
        {
            double allowedCapacity = _isHazardous ? MaxCapacity * 0.5 : MaxCapacity * 0.9;
            if (LoadWeight + weight > allowedCapacity)
            {
                NotifyHazard($"Próba przeładowania niebezpiecznego kontenera {SerialNumber}!");
                throw new OverfillException($"Przekroczono bezpieczny poziom ładunku kontenera {SerialNumber}.");
            }
            base.Load(weight);
        }

        public void NotifyHazard(string message) => Console.WriteLine($"[ALERT] {SerialNumber}: {message}");
    }
}