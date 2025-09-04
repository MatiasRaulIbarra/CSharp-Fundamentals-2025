namespace CSharpFundamentals.Core.Models.ATM
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount(string accountNumber, decimal initialBalance, decimal overdraftLimit)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            OverdraftLimit = overdraftLimit;


        }


        public override void Withdraw(decimal amount)
        {

            if (amount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive");
                return;
            }

            if (Balance + OverdraftLimit < amount)
            {
                Console.WriteLine($"Error: Overdraft limit exceeded.Cannot withdraw ${amount}.");
                return;
            }


            Balance -= amount;
            Console.WriteLine($"Success: Withdrawal of ${amount} was successful. New balance is: ${Balance}");
        }



        public CheckingAccount() { }
    }
}
