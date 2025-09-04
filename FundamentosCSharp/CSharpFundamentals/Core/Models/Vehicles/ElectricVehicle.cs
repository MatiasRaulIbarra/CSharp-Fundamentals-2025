using CSharpFundamentals.Core.Interfaces.Vehicles;

namespace CSharpFundamentals.Core.Models.Vehicles
{
    public class ElectricVehicle : IMotor
    {
        public  void  Start()
        {
            Console.WriteLine("Electric vehicle is starting...");
        }

        public void ChargeBatterry()
        {
            Console.WriteLine("Charging the electric vehicle's battery.");
        }
    }
}
