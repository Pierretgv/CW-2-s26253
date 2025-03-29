

namespace ContainerManagement.Transport
{
    public class Train : TransportVehicle
    {
        public int NumCarriages { get; }

        public Train(int maxContainers, double maxWeight, int numCarriages)
            : base(maxContainers, maxWeight)
        {
            NumCarriages = numCarriages;
        }

        /// <summary>
        /// Sprawdza, czy liczba kontenerów odpowiada liczbie wagonów.
        /// </summary>
        public void CheckCarriageLoad()
        {
            if (Containers.Count > NumCarriages)
                Console.WriteLine(
                    $"🚂 Uwaga! Przeciążenie pociągu. Kontenery: {Containers.Count}, wagony: {NumCarriages}.");
            else
                Console.WriteLine(
                    $"🚂 Pociąg gotowy do odjazdu. {Containers.Count}/{NumCarriages} wagonów załadowanych.");
        }

        public override string ToString() =>
            $"🚂 Pociąg przewozi {Containers.Count}/{MaxContainers} kontenerów. Wagony: {NumCarriages}, Całkowita masa: {GetTotalWeight()} kg.";
    }
}