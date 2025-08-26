namespace CSharpFundamentals
{
    public static class Day4_SwitchStatement
    {

        public static void EvaluateDayOfWeek()
        {

            Console.WriteLine("----Day of the week evaluator----");
            Console.WriteLine("Please enter a number between 1 and 7");
            string userInput = Console.ReadLine();
            int dayNumber;

            if (!int.TryParse(userInput, out dayNumber))
            {
                Console.WriteLine("Error: You must enter a valid number");
                return;
            }

            if (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Error: The number must be between 1 and 7");
                return;
            }

            //Switch statement to evaluate the day of the week based on the number provided by the user.
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is Monday");
                    break;
                case 2:
                    Console.WriteLine("The day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The day is Friday");
                    break;
                case 6:
                    Console.WriteLine("The day is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The day is Sunday");
                    break;
                default:
                    // This default case should never be reached due to prior validation.
                    Console.WriteLine("Error: Invalid day number");
                    break;
            }

            Console.ReadKey();
        }

        public static void EvaluateSeasonsSouthernHemisphere()
        {
            Console.WriteLine("----Season Evaluator for the Southern Hemisphere----");
            Console.WriteLine("Please enter a month  (January-December)");
            string userInput = Console.ReadLine();

            switch (userInput.Trim().ToLower())
            {
                case "december":
                case "january":
                case "february":
                    Console.WriteLine("The season is Summer");
                    break;

                case "march":
                case "april":
                case "may":
                    Console.WriteLine("The season is Autumn");
                    break;
                case "june":
                case "july":
                case "august":
                    Console.WriteLine("The season is Winter");
                    break;
                case "september":
                case "october":
                case "november":
                    Console.WriteLine("The season is Spring");
                    break;

                default:
                    Console.WriteLine("Error: Invalid month name");
                    break;

            }
            

        }

    }
}
