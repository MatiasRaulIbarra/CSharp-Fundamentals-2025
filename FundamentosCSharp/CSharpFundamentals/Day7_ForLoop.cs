namespace CSharpFundamentals
{
    public static class Day7_ForLoop
    {


        public static void FactorialCalculator()
        {
            string inputUser;
            int inputNumber;
            long factorial = 1;

            Console.WriteLine("Please enter a number");
            inputUser = Console.ReadLine();

            if (int.TryParse(inputUser, out inputNumber) && inputNumber > 0)
            {

                for (int i = 1; i <= inputNumber; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Factorial of {inputNumber} is {factorial}.");

            }
            else
            {
                Console.WriteLine("Invalid number.Please try again");
            }

            
        }


        public static void VowelCounter()
        {
            string inputUser;
            int vowelCount = 0;
            Console.WriteLine("Please enter a sentence or word:");
            inputUser = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputUser))
            {
                string textToLower = inputUser.ToLower();
                for (int i = 0;i < textToLower.Length; i++)
                {

                    char c = textToLower[i];
                    if ("aeiou".Contains(c))
                    {
                        vowelCount++;
                    }
                }
            }




            Console.WriteLine($"The number of vowels in the input is: {vowelCount}");
            Console.ReadKey();



        }


        public static void VowelCounterForEach()
        {
            string inputUser;
            int vowelCount = 0;
            Console.WriteLine("Please enter a sentence or word");
            inputUser = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputUser))
            {

                foreach (char c in inputUser.ToLower())
                {
                    if ("aeiou".Contains(c))
                    {
                        vowelCount++;
                    }

                }
            }
            Console.WriteLine($"The number or vowels in the input is:{vowelCount}");
            Console.ReadKey();
        }
    }
}
