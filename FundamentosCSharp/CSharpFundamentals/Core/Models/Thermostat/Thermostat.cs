namespace CSharpFundamentals.Core.Models.Thermostat
{
    public class Thermostat
    {
        private double _currentTemperature;


        public Thermostat()
        {
            _currentTemperature = 15.0;
        }

        public double GetTemperature()
        {
            return _currentTemperature;
        }

        public void IncreaseTemperature(double amout)
        {

            double newTemperature = _currentTemperature + amout;
            if (amout > 30)
            {
                _currentTemperature = 30;
                Console.WriteLine("Temperature set to maximun (30°C).");


            }
            else
            {
                _currentTemperature = newTemperature;
            }

        }

        public void DecreaseTemperature(double amout)
        {
            double newTemperature = _currentTemperature - amout;
            if (newTemperature < 10)
            {
                _currentTemperature = 10;
                Console.WriteLine("Temperature set to minimum (10°C).");
            }
            else
            {
                _currentTemperature = newTemperature;
            }
        }
    }
}
