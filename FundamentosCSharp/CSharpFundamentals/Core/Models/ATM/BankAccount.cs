namespace CSharpFundamentals.Core.Models.ATM
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }


        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
                return;
            }

            Balance += amount;

            Console.WriteLine($"Success: Deposit of ${Balance} was successful.New balance is:{Balance}");

        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return;
            }

            if (Balance < amount)
            {
                Console.WriteLine($"Error: Insufficient balance. You tried to withdraw ${amount} but only have ${Balance}.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Success: Withdrawal of ${amount} was successful. New balance is: ${Balance}");
        }
    }
}
