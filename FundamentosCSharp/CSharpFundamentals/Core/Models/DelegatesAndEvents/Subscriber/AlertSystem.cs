using CSharpFundamentals.Core.Models.DelegatesAndEvents.Publisher;

namespace CSharpFundamentals.Core.Models.DelegatesAndEvents.Subscriber
{
    public class AlertSystem
    {
        public void Subscribe(TemperatureSensor temperatureSensor)
        {
            temperatureSensor.HighTemperatureDetected += OnHighTemperatureDetected;
        }

        public void OnHighTemperatureDetected(double temperature)
        {
            Console.WriteLine($"Alert: Temperature is {temperature}°C");
        }
    }


}
