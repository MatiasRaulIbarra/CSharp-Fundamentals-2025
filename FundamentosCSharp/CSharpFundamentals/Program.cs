using CSharpFundamentals;


while (true)
{
    Console.Clear();
    Console.WriteLine("--- MY C# PRACTICE LAB ---");
    Console.WriteLine("--------------------------");
    Console.WriteLine("Week 1: Fundamentals & Logic");
    Console.WriteLine("1.  Day 1:program that requests data from the user via console");
    Console.WriteLine("2.  Day 2:program that determines whether a book was borrowed or returned");
    Console.WriteLine("3.  Day 3:Grade Evaluator");
    Console.WriteLine("4.  Day 3:Login & Credit Simulator");
    Console.WriteLine("5.  Day 4:Day of the Week Evaluator (switch)");
    Console.WriteLine("6.  Day 4:Season Detector (switch)");
    Console.WriteLine("7.  Day 5:Guess the Number (while)");
    Console.WriteLine("8.  Day 6:Persistent Menu (do-while)");
    Console.WriteLine("9.  Day 6:Cumulative Sum (do-while)");
    Console.WriteLine("10. Day 7:Factorial Calculator(For)");
    Console.WriteLine("11. Day 7:Vowel Counter(For)");
    Console.WriteLine("12. Day 7:Vowel Counter(Foreach)");
    Console.WriteLine("13. Day 8:User Profile(Constructors & encasulaption)");
    Console.WriteLine("14. Day 8:Smart Thermostat (Constructors & encasulaption)");
    Console.WriteLine("15. Day 9:Bank Account (Inheritence)");
    Console.WriteLine("16. Day 9:Employee exercise(Inherintence)");
    Console.WriteLine("17. Day 10:Animal Sound (Polymorphism)");
    Console.WriteLine("18. Day 10:Payment System(Polymorphism)");
    Console.WriteLine("19. Day 11:The Data Reader(Interfaces)");
    Console.WriteLine("20. Day 11:Electric & Combustion Vehicles(Interfaces)");
    Console.WriteLine("21. Day 12:Geometric Shapes System(AbstractClass & Static Method) ");
    Console.WriteLine("22. Day 12:Static Data Validator(AbstractClass & Static Method)");
    Console.WriteLine("23. Day 13:Product inventory(Array)");
    Console.WriteLine("24. Day 13:Game Ranking(Array)");
    Console.WriteLine("25. Day 14:Music Playlist Manager(Collections(List<T>))");
    Console.WriteLine("26. Day 14:User-Entered Numbers(Collections(List<T>)");
    Console.WriteLine("27. Day 15:Account Withdrawal(ExceptionsHandling)");
    Console.WriteLine("28. Day 15:Age Validator(ExceptionsHandling)");
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
            case 10:
                Day7_ForLoop.FactorialCalculator();
                break;
            case 11:
                Day7_ForLoop.VowelCounter();
                break;
            case 12:
                Day7_ForLoop.VowelCounterForEach();
                break;
            case 13:
                Day8_ConstructorsAndEncapsulation.ExecuteUserProfile();
                break;
            case 14:
                Day8_ConstructorsAndEncapsulation.ExecuteThermostat();
                break;
            case 15:
                Day9_Inheritance.ExecuteBankAccountExercise();
                break;
            case 16:
                Day9_Inheritance.ExecuteEmployee();
                break;
            case 17:
                Day10_Polymorphism.ExecuteAnimalSound();
                break;
            case 18:
                Day10_Polymorphism.ExecutePaymentSystem();
                break;
            case 19:
                Day11_Interfaces.ExecuteDataReader();
                break;
            case 20:
                Day11_Interfaces.Execute_Electric_CobustionVehicles();
                break;
            case 21:
                Day12_AbstractClassAndStaticMethod.ExecuteShapesSystem();
                break;
            case 22:
                Day12_AbstractClassAndStaticMethod.ExecuteStaticDataValidator();
                break;
            case 23:
                Day13_Array.ExecuteProductInventory();
                break;
            case 24:
                Day13_Array.ExecuteGameRanking();
                break;
            case 25:
                Day14_Collections_ListT_.ExecuteMusicPlaylistManager();
                break;
            case 26:
                Day14_Collections_ListT_.UserEnteredNumbers();
                break;
            case 27:
                Day15_ExceptionsHandling.ExecuteAccountWithdrawal();
                break;
            case 28:
                Day15_ExceptionsHandling.ExecuteAgeValidator();
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



