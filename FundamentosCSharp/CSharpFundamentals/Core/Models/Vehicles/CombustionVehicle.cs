using CSharpFundamentals.Core.Interfaces.Vehicles;

namespace CSharpFundamentals.Core.Models.Vehicles
{
    public class CombustionVehicle : IMotor
    {
        public void Start()
        {
            Console.WriteLine("Combustion Vehicle is starting..");
        }

        public void FillTank()
        {
            Console.WriteLine("Empty fuel tank");
        }
    }
}
