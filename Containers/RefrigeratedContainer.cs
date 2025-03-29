namespace ContainerManagement.Containers
{
    public class RefrigeratedContainer : Container
    {
        public string ProductType { get; }
        public double Temperature { get; }

        public RefrigeratedContainer(double maxCapacity, double height, double ownWeight, double depth, string productType, double temperature)
            : base(maxCapacity, height, ownWeight, depth, "C")
        {
            ProductType = productType;
            Temperature = temperature;
        }
    }
}