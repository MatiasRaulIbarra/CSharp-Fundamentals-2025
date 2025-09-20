namespace CSharpFundamentals.Core.Async_TPL
{
    public class DataProcessor
    {
        public async Task<long> CalculateFactorial(long number)
        {
            await Task.Delay(1000);
            if (number < 0)
            {
                throw new ArgumentException("El número no puede ser negativo.");
            }

            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;

            

        }


        public async Task<long[]> ProcessFactorialsAsync( List<int> numbers)
        {
            var tasks = new List<Task<long>>();

            foreach (var number in numbers)
            {
                tasks.Add(CalculateFactorial(number));
            }
            var results =  await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                Console.WriteLine($"Factorial result: {result}");
            }

            return results;
        }
    }
}
