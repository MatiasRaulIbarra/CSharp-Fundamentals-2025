namespace CSharpFundamentals
{
    public static class Day03_Conditionals
    {




        //Method to evaluate a student's grade and print the corresponding result.
        public static void EvaluateGrade()
        {
            Console.WriteLine("----Grade Evaluator----");
            Console.WriteLine("Please enter the student's grade (0-10)");

            string userInput = Console.ReadLine();
            int numericGrade;


            // ---GUARD CLAUSE 1 : Check if the input is a valid number---
            if (!int.TryParse(userInput, out numericGrade))
            {
                Console.WriteLine("Error: You must enter a valid number");
                return;
            }
            // ---GUARD CLAUSE 2 : Check if the number is within the valid range---
            if (numericGrade < 0 || numericGrade > 10)
            {
                Console.WriteLine("Error: The grade must be between 0 and 10");
                return;
            }
            // Evaluating the grade and printing the corresponding result.
            // "Happy Path" - the main logic of the method.
            if (numericGrade >= 9)
            {
                Console.WriteLine("Result: Excellent");
            }
            else if (numericGrade >= 7)
            {
                Console.WriteLine("Result : Very good");
            }
            else if (numericGrade >= 6)
            {
                Console.WriteLine("Result: Approved");
            }

            else
            {
                Console.WriteLine("Result: Not approved");
            }

        }


        //------------------------------------------------------------------------
        //Mini Logging

        public static void LoggingCheck()
        {

            string correctUsername = "matias";
            string correctPassword = "123456";
            


            Console.WriteLine("Welcome to the crypto Wallet :\nPlease Enter your user name");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string inputPassword = Console.ReadLine();


            if (inputUsername?.Trim().ToLower() == correctUsername && inputPassword == correctPassword )
            {
                Console.WriteLine("Welcome to your wallet");
            }
            else
            {
                Console.WriteLine("Error: Incorrect username or password");
            }

            Console.ReadKey();
        }


        //---Blueprint 

        public static void CreditEvaluator()
        {
            Console.WriteLine("------ Welcome to Credit Evaluator ------");

            // 1. Define correct credentials
            string correctUsername = "matias";
            string correctPassword = "password123";

            // 2. Ask for user input
            Console.Write("Please enter your username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string inputPassword = Console.ReadLine();

            // --- 3. Login Validation (Guard Clause) ---
            if (inputUsername.Trim().ToLower() == correctUsername && inputPassword.Trim() == correctPassword)
            {
                Console.WriteLine("\nAccess Granted. Welcome!");

                Console.Write("Please enter your current balance: ");
                string inputBalance = Console.ReadLine();
                decimal convertedBalance;

                // --- 4. Balance Validation (Guard Clause) ---
                if (!decimal.TryParse(inputBalance, out convertedBalance) || convertedBalance < 0)
                {
                    Console.WriteLine("Error: You must enter a valid, non-negative number.");
                    return; // CRUCIAL: Stop execution if the balance is invalid.
                }

                // --- 5. Credit Logic using a proper 'if / else if / else' chain ---
                Console.Write("Result: ");
                if (convertedBalance > 50000)
                {
                    Console.WriteLine("You qualify for a Mortgage Loan.");
                }
                else if (convertedBalance > 10000)
                {
                    Console.WriteLine("You qualify for a Car Loan.");
                }
                else if (convertedBalance > 1000)
                {
                    Console.WriteLine("You qualify for a Personal Loan.");
                }
                else
                {
                    Console.WriteLine("You do not qualify for any pre-approved loans at this time.");
                }
            }
            else
            {
                Console.WriteLine("Error: Incorrect username or password.");
            }

            Console.ReadKey();
        }


    }
      

       
            
}
