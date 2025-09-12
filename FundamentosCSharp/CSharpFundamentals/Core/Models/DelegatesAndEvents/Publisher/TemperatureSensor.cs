namespace CSharpFundamentals.Core.Models.DelegatesAndEvents.Publisher
{
    public class TemperatureSensor
    {
        private double Temperature { get; set; }
        public delegate void TemperatureHandler(double temperature);
        public event TemperatureHandler HighTemperatureDetected;

        public void SetTemperature(double temperature)
        {
            Temperature = temperature;
            if(temperature > 30)
            {
                HighTemperatureDetected?.Invoke(temperature);
            }
        }
    }
}
