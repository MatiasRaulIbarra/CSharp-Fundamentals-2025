namespace CSharpFundamentals.Core.Models.Exceptions
{
    public class Account
    {
        public double Balance { get; set; }


        public void Withdraw(double amount)
        {

            if (amount > Balance)
            {
                throw new InvalidOperationException("Withdrawal amount exceeds balance.");
            }

            Balance -= amount;
        }

        public Account(double balance)
        {
            this.Balance = balance;
        }
    }
}
