using CSharpFundamentals.Core.Models.DelegatesAndEvents.Publisher;

namespace CSharpFundamentals.Core.Models.DelegatesAndEvents.Subscriber
{
    public class ProgressNotifier
    {

        public void Subscribe(FileProcessor processor)
        {
            processor.ProgressUpdate += OnProgressUpdate;
        }


        public void OnProgressUpdate(int percentaje)
        {
            Console.WriteLine($"Progress: {percentaje}%");
        }


    }
}
