using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.Principle_LSP
{
    public class HumanWorker : Iworker, IWorkeable, ILivingBeing
    {
        public void Eat()
        {
            Console.WriteLine("Human is eating.");
        }

        public void EatLSP()
        {
            Console.WriteLine("Human is eating and applying Liskov Sustitution  Principle.");
        }

        public void Sleep()
        {
            Console.WriteLine("Human is sleeping.");
        }

        public void SleepLSP()
        {
            Console.WriteLine("Human is sleeping and applying Liskov Sustitution  Principle.");
        }

        public void Work()
        {
            Console.WriteLine("Human is working.");
        }

        public void WorkLSP()
        {
            Console.WriteLine("Human is working and applying  Liskov Sustitution  Principle.");
        }
    }
}
