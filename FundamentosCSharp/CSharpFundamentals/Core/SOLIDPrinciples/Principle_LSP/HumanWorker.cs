using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.Principle_LSP
{
    public class HumanWorker : IWorkeable, ILivingBeing
    {


        public void EatLSP()
        {
            Console.WriteLine("Human is eating and applying Liskov Sustitution  Principle.");
        }



        public void SleepLSP()
        {
            Console.WriteLine("Human is sleeping and applying Liskov Sustitution  Principle.");
        }



        public void WorkLSP()
        {
            Console.WriteLine("Human is working and applying  Liskov Sustitution  Principle.");
        }
    }
}
