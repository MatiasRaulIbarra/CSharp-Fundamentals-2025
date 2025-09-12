namespace CSharpFundamentals
{
    public static class Day06_DoWhileLoop
    {
        public static void PersistentOptionMenu()
        {
            string userInput;

            do
            {


                Console.WriteLine("\n---- Main Menu ----");
                Console.WriteLine("a) Greeting");
                Console.WriteLine("b) Say Goodbye");
                Console.WriteLine("c) Exit");
                Console.WriteLine("Please choose an option.");
                userInput = Console.ReadLine();


                
                switch(userInput?.Trim().ToLower())
                {
                    case "a":
                        Console.WriteLine("--> Hello! Welcome.");
                        break;
                    case "b":
                        Console.WriteLine("--> Goodbye! See you later.");
                        break;
                    case "c":
                        Console.WriteLine("--> Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("--> Error: Invalid option. Please try again.");
                        break;
                }
                
            }
            while (userInput?.Trim().ToLower() != "c");
        }

        public static void CumulativeSum()
        {
            decimal totalSum = 0;
            decimal inputNumber;
            do
            {
                Console.WriteLine("\n Please enter  a  number to add to the sum (or enter 0 to exit).");
                 string  inputUser = Console.ReadLine();
                

                if (decimal.TryParse(inputUser, out inputNumber))
                {
                    totalSum += inputNumber;
                    Console.WriteLine($"Current sum: {totalSum}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number");
                }
               
                
            }
            while (inputNumber != 0);

            Console.WriteLine($"\nFinal sum is: {totalSum}. Program finished.");
            Console.ReadKey();
        }
    }
}
