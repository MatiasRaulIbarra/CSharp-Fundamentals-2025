using CSharpFundamentals.Core.Models.Exceptions;
using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals
{
    public static class Day15_ExceptionsHandling
    {
        public static void ExecuteAccountWithdrawal()
        {

            Account account = new Account(10500);

            try
            {
                account.Withdraw(5000);
                Console.WriteLine($"The current balance is: {account.Balance}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public static void ExecuteAgeValidator()
        {
            AgeValidator ageValidator = new AgeValidator();


            Console.WriteLine("---- Testing a valid age ----");
            try
            {
                ageValidator.VerifyAge(115);
                Console.WriteLine("Age is valid");

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\n---- Testing an invalid age ----");
            try
            {
                ageValidator.VerifyAge(-5);
                Console.WriteLine("This line will not be executed.");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
