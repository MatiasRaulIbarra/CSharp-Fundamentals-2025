using CSharpFundamentals.Core.Async_TPL;
using System.Reflection.Metadata.Ecma335;

namespace CSharpFundamentals
{
    public static class Day22_Async_TPL
    {
        public async static void Async_TPL()
        {
            DownloadContent downloadContent = new DownloadContent();
            SequentialDownloader sequentialDownloader = new SequentialDownloader(downloadContent);
            await sequentialDownloader.DownloadWebsites();


        }

        public async static void ExecuteCalculateFactorial()
        {
            Console.WriteLine("---- Calculating factorials for predefinided numbers ---- ");

            DataProcessor dataProcessor = new DataProcessor();
            long result = await dataProcessor.CalculateFactorial(10);

            Console.WriteLine($"The factorial of 10 is: {result}");
            Console.WriteLine("Calculation complete.");
        }

        public async static void ExecuteProcessFactorialsAsync()
        {
            Console.WriteLine("---- Calculating factorials for a list of numbers ----");
            DataProcessor dataProcessor = new DataProcessor();
            List<int> numbers = new List<int>();
            numbers.Add(11);
            numbers.Add(10);
            numbers.Add(5);

            long[] results = await dataProcessor.ProcessFactorialsAsync(numbers);
        }
    }
}
