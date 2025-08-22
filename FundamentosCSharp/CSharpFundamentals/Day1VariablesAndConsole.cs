
namespace CSharpFundamentals
{
    public static  class Day1VariablesAndConsole
    {
        public  static  void Ejecutar()
        {
            // Simple practice with data types and handling manual user input.

            DateTime date = DateTime.Now;
            Console.WriteLine("Hello what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name} ");
            Console.WriteLine($"How old are you {name} ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It's a perfect age");

            Console.WriteLine($"It's a beautiful day {date:dd/MM}");
            Console.WriteLine("would you like to know the current year? yes/not");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine($"The year is {date: yyyy} ");
            }
            else
            {
                Console.WriteLine("Okay thank you ");
            }



            // Using a verbatim string (@) for cleaner multi-line output without repeating code.

            string name2 = "Matt";
            int age2 = 00;
            DateTime date2 = DateTime.Now;

            Console.WriteLine(@$"Nice to meet you  {name2}.
               your age {age2} is excellet
               The current date  is {date2: dd/MM/yyyy}
               Have a good day {name2}.
            ");

        }
    }
}
