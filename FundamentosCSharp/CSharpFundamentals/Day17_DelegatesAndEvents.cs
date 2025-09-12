using CSharpFundamentals.Core.Models.DelegatesAndEvents.Publisher;
using CSharpFundamentals.Core.Models.DelegatesAndEvents.Subscriber;

namespace CSharpFundamentals
{
    public static  class Day17_DelegatesAndEvents
    {

        public static void ExecuteFileProcessor()
        {
            FileProcessor fileProcessor = new FileProcessor();
            ProgressNotifier notifier = new ProgressNotifier();

            notifier.Subscribe(fileProcessor);
            fileProcessor.ProcessFile("my_document.txt");
            
        }


        public static void ExecuteTemperatureSensor()
        {
            TemperatureSensor temperatureSensor = new TemperatureSensor();
            AlertSystem alertSystem = new AlertSystem();
            alertSystem.Subscribe(temperatureSensor);

            temperatureSensor.SetTemperature(31);
        }
    }
}
