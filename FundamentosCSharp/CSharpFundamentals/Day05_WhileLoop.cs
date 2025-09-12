using System;

namespace CSharpFundamentals
{
    public static class Day05_WhileLoop
    {
        public static void FibonacciSequence()
        {
            int a = 0, b = 1, nextTerm;
            Console.WriteLine("Fibonacci Sequence:");

            while (a <= 100)
            {
                Console.Write(a + " ");
                nextTerm = a + b;
                a = b;
                b = nextTerm;
            }
        }

        public static void GuessTheNumber()
        {
            Random ramdom = new Random();
            int secretNumber = ramdom.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("----Guess the Number Game----");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

            while (userGuess != secretNumber)
            {
                Console.WriteLine("Enter your guess:");
                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out userGuess))
                {
                    Console.WriteLine("That's not a valid number.Please try again.");
                    continue;
                }

                attempts++;

                if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }


            }

            Console.WriteLine($"Congratulations! You've guessed the number ,it was{secretNumber}");
            Console.WriteLine($"You took {attempts} attempts to guess the number.");
        }


        public static void InputValidator()
        {

            Console.WriteLine("-----Enter you age-----");
            int ValidAge;

            while (true)
            {
                Console.WriteLine("Please enter your age (1-120):");
                string userInput = Console.ReadLine();
                int age;
                if(! int.TryParse(userInput, out age))
                {
                    Console.WriteLine("Error:That's not a number.Please try again.");
                }
                if(age < 1 || age > 120)
                {
                    Console.WriteLine("Error:The age must be between 1 and 120.Please try again.");
                    continue;
                }

                ValidAge = age;
                break;
            }


            Console.WriteLine($"Thank you.Your age,{ValidAge}, have been registered");
            Console.WriteLine("Success");
            
        }

        public static void SimulatorCashMachine_ATM()
        {
            decimal balance = 10000.50m;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"--- Welcome to your ATM ---");
                Console.WriteLine($"Your current balance is {balance}");
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Your choice: ");

                if(!int.TryParse(Console.ReadLine(), out int menuOption))
                {
                    Console.WriteLine("Invalid option. Press Enter to try again.");
                    Console.ReadKey();
                    continue;
                }

                switch (menuOption)
                {
                 

                    case 1:
                        if(decimal.TryParse(Console.ReadLine(), out decimal depositAmmount) && depositAmmount >0)
                        {
                            balance += depositAmmount;
                            Console.WriteLine($"Success! Your new balance is: ${balance}");

                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to withdraw:");
                        if(decimal.TryParse(Console.ReadLine(),out decimal withdrawAmount ) && withdrawAmount > 0)
                        {
                            if(withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Success! Your new balance is: ${balance}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        Console.ReadKey();
                        return; 

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1, 2, or 3.");
                        break;


                }

                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadKey();



            }
        }
        
     }
}
