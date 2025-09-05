using CSharpFundamentals.Core.Models.Shapes;
using CSharpFundamentals.Core.Models.Validators;
using System.ComponentModel.Design;

namespace CSharpFundamentals
{
    public static class Day12_AbstractClassAndStaticMethod
    {

        public static void ExecuteShapesSystem()
        {
            Console.WriteLine("--- Please choose an option ---");
            Console.WriteLine("1. Calculate the area of a circle");
            Console.WriteLine("2. Calculate the area of a Square");
            string userOption = Console.ReadLine();


            if (int.TryParse(userOption, out int numberUserOption) & (numberUserOption == 1) || (numberUserOption == 2))
            {
                Console.WriteLine("Please enter a number");
                string numberOption = Console.ReadLine();


                if (double.TryParse(numberOption, out double userCalculateOption))
                {


                    switch (numberUserOption)
                    {
                        case 1:
                            Circle circle = new Circle();
                            circle.radius = userCalculateOption;
                            //circle.CalculateArea();
                            Console.WriteLine($"The area of the circle is: {circle.CalculateArea()}");
                            break;

                        case 2:
                            Square square = new Square();
                            square.side = userCalculateOption;
                            Console.WriteLine($"The area of a square is: {square.CalculateArea()}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid number for the calculation.");
                }



            }
            else
            {
                Console.WriteLine("Error:Invalid input. Plase enter a valid option (1 or 2). ");
            }
        }



        public static void ExecuteStaticDataValidator()
        {
 
            Console.WriteLine($"Is 'mamasd' a valid email?  {DataValidator.IsValidEmail("mamasd")}");
            Console.WriteLine($"Is '-1' a positive number? {DataValidator.IsPositiveNumber(-1)}");
        }

    }


}
