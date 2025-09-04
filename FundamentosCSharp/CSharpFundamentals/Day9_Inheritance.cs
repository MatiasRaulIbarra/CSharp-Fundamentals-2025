using CSharpFundamentals.Core.Models.ATM;
using CSharpFundamentals.Core.Models.User;

namespace CSharpFundamentals
{
    public static class Day9_Inheritance
    {

        public static void ExecuteBankAccountExercise()
        {
            Console.WriteLine("--- Testing Saving Account ---");
            SavingsAccount mySavings = new SavingsAccount(1000, 0.05m);
            mySavings.AccountNumber = "SA-001";


            Console.WriteLine($"Initial Balance: ${mySavings.Balance}");
            mySavings.Deposit(500);
            mySavings.Withdraw(200);

            Console.WriteLine($"Final Balance for{mySavings.AccountNumber} : ${mySavings.Balance}");

            Console.WriteLine("\n --- Testing Checking Account ---");
            CheckingAccount myChecking = new CheckingAccount();
            myChecking.AccountNumber = "CA-002";
            myChecking.Deposit(200);
            myChecking.OverdraftLimit = 100;

            Console.WriteLine($"Initial Balance: ${myChecking.Balance}");
            myChecking.Withdraw(350);

            Console.WriteLine($"Final Balance for {myChecking.AccountNumber}: ${myChecking.Balance}");

        }



        public static void ExecuteEmployee()
        {
            Console.WriteLine("--- Testing Employee ---");
            Manager manager = new Manager(1,"Matias",1005.4m,"Finanzas");
            Console.WriteLine($@" 
            --- Manager Profile ---
            EmployeeId :{manager.EmployeeId}
            Name: {manager.Name}
            Salary: {manager.Salary}
            Department: {manager.Department}");

            Console.WriteLine("--- Testing Employee Developer ---");
            Developer developer = new Developer(2,"Juan",1003.2m, "C#");
            Console.WriteLine($@" 
            ---  Developer Profile ---
            EmployeeId :{developer.EmployeeId}
            Name:{developer.Name}
            Salary:{developer.Salary}
            Programming Language: {developer.ProgrammingLanguage}");

        }
    }
}
