namespace CSharpFundamentals.Models
{
    public class PayPal : PaymentSystem
    {
        public override void ProcessPayment(double amount)
        {
            base.ProcessPayment(amount);
            if (amount > 0)
            {
                Console.WriteLine("Processing payment via Credit Card...");
            }
        }
    }
}
