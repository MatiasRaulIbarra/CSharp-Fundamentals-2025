using CSharpFundamentals.Models;

namespace CSharpFundamentals
{
    public static  class Day10_Polymorphism
    {
        public static void ExecuteAnimalSound()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog());
            animals.Add(new Cat());

            Console.WriteLine("--- Simple Polymorphism Example ---");

            foreach (var animal in animals)
            {
                animal.Sound();
            }
        }

        public static void ExecutePaymentSystem()
        {
          List<PaymentSystem> paymentSystems = new List<PaymentSystem>();
          paymentSystems.Add(new CreditCard());
          paymentSystems.Add(new PayPal());


            double balance;
            Console.WriteLine("--- Welcome to payment system ---");
            Console.WriteLine("Please enter the total to pay.");
            string  inputAmount = Console.ReadLine();

            if(double.TryParse(inputAmount, out balance))
            {
                foreach (var paymentSystem in paymentSystems)
                {
                    paymentSystem.ProcessPayment(balance);
                }
            }
            else
            {
                Console.WriteLine("Error: The ");
            }

           
        }
    }
}
