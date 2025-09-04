using CSharpFundamentals.Core.Interfaces.Data;
using CSharpFundamentals.Core.Interfaces.Vehicles;
using CSharpFundamentals.Core.Models.DataSource;
using CSharpFundamentals.Core.Models.Vehicles;
using File = CSharpFundamentals.Core.Models.DataSource.File;

namespace CSharpFundamentals
{
    public static class Day11_Interfaces
    {

        public static void ExecuteDataReader()
        {
            List<IReadable> readables = new List<IReadable>();

            readables.Add(new DataBase());
            readables.Add(new File());

            string aditionalMessage = "Hi, your data is from:";

            foreach(var readable  in readables)
            {
                readable.ReadData(aditionalMessage);
            }

        }

        public static void Execute_Electric_CobustionVehicles()
        {
            Console.WriteLine("--- Please select a vehicle ---");
            Console.WriteLine("1. for Electric Vehicle");
            Console.WriteLine("2. for Combustion Vehicle");

            string vehicleOption = Console.ReadLine();

            

            if(int.TryParse( vehicleOption, out int  inputVehicle))
            {

                switch (inputVehicle)
                {
                    case 1:
                        ElectricVehicle electricVehicle = new ElectricVehicle();
                        electricVehicle.Start();
                        electricVehicle.ChargeBatterry();
                        break;
                    case 2:
                        CombustionVehicle combustionVehicle = new CombustionVehicle();
                        combustionVehicle.Start();
                        combustionVehicle.FillTank();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1 or 2.");
                        break;

                }
            }

            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a number.");
            }



            
        }
    }
}
