using CSharpFundamentals;


while (true)
{
    Console.Clear();
    Console.WriteLine("--- MY C# PRACTICE LAB ---");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Week 1: Fundamentals & Logic");
    Console.WriteLine("1. Day 1:program that requests data from the user via console");
    Console.WriteLine("2. Day 2:program that determines whether a book was borrowed or returned");
    Console.WriteLine("3. Day 3: Grade Evaluator");
    Console.WriteLine("4. Day 3: Login & Credit Simulator");
    Console.WriteLine("5. Day 4: Day of the Week Evaluator (switch)");
    Console.WriteLine("6. Day 4: Season Detector (switch)");
    Console.WriteLine("7. Day 5: Guess the Number (while)");
    Console.WriteLine("8. Day 6: Persistent Menu (do-while)");
    Console.WriteLine("9. Day 6: Cumulative Sum (do-while)");
    Console.WriteLine("--------------------------");
    Console.WriteLine("0. Exit Program");
    Console.WriteLine("--------------------------");
    Console.Write("\nPlease enter the number of the exercise you want to run: ");

    string choice = Console.ReadLine();

    if (int.TryParse(choice, out int option))
    {
        Console.Clear(); // Clear the console before running the exercise

        switch (option)
        {
            case 1:
                Day1_VariablesAndConsole.Ejecutar();
                break;
            case 2:
                Day2_OperatorsAndMethods.Ejecutar();
                break;

            case 3:
                Day3_Conditionals.EvaluateGrade();
                break;
            case 4:
                Day3_Conditionals.CreditEvaluator();
                break;
            case 5:
                Day4_SwitchStatement.EvaluateDayOfWeek();
                break;
            case 6:
                Day4_SwitchStatement.EvaluateSeasonsSouthernHemisphere();
                break;
            case 7:
                Day5_WhileLoop.GuessTheNumber();
                break;
            case 8:
                Day6_DoWhileLoop.PersistentOptionMenu();
                break;
            case 9:
                Day6_DoWhileLoop.CumulativeSum();
                break;
            case 0:
                Console.WriteLine("Exiting the lab. Goodbye!");
                return; 
            default:
                Console.WriteLine("Invalid option. Please choose a number from the list.");
                break;
        }

        Console.WriteLine("\n\n--- End of exercise ---");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Invalid input. Press any key to try again.");
        Console.ReadKey();
    }
}



