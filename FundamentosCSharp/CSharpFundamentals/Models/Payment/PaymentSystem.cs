namespace CSharpFundamentals.Models.Payment
{
    public class PaymentSystem
    {

        /// <summary>
        /// Here I define the method Process payment
        /// </summary>

        public virtual void ProcessPayment(double amount)
        {

            if (amount <= 0)
            {
                Console.WriteLine("Error: The amount must be greater than zero.");
                return;
            }
            Console.WriteLine($"Initiating payment process for ${amount}.");


        }
    }
}
