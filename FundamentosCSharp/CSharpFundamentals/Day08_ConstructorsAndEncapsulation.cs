using CSharpFundamentals.Core.Models.Thermostat;
using CSharpFundamentals.Core.Models.UserProfile;

namespace CSharpFundamentals
{
    public static class Day08_ConstructorsAndEncapsulation
    {

        public static void ExecuteUserProfile()
        {
            Console.WriteLine("---- Testing UserProfile ----");

            UserProfile profile =  new UserProfile("Matías", "test@email.com");

            Console.WriteLine($"UserName: {profile.GetUserName()}");
            Console.WriteLine($"Email: {profile.GetEmail()}");
            Console.WriteLine($"Registered on: {profile.GetRegistrationDate()}");


            Console.WriteLine("\n Updating email...");
            profile.UpdateEmail("new.email@example.com");

            Console.WriteLine($"New email :{profile.GetEmail()}");
        }


        public static void ExecuteThermostat()
        {
            Console.WriteLine("----  Testing Thermostat  ----");
            Thermostat thermostat = new Thermostat();

            Console.WriteLine($"Initial temperature: {thermostat.GetTemperature()}");
            Console.WriteLine($"\nIncreaseasign temperature by 5...");
            thermostat.IncreaseTemperature(5);
            Console.WriteLine($"\nCurrent Temperature: {thermostat.GetTemperature()}");
            Console.WriteLine($"\nIncreasing temperature by 20...");
            thermostat.IncreaseTemperature(20);



            Console.WriteLine($"\nDecrease Themperature by 25...");
            thermostat.DecreaseTemperature(25);
            Console.WriteLine($"Current Temperature: {thermostat.GetTemperature()}");

        }
    }
}
