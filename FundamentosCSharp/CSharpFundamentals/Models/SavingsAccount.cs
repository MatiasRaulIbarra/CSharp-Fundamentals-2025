
namespace CSharpFundamentals.Models
{
    public  class SavingsAccount : BankAccount
    {
        public decimal InterestRate {  get; set; }


        public SavingsAccount(decimal balance, decimal interestRate)
        {
            AccountNumber = "SA-Default";
            Balance = balance;
            InterestRate = interestRate;

        }
        public SavingsAccount() { }
    }

}
