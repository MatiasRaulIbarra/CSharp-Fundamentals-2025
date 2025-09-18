using CSharpFundamentals.Core.SOLIDPrinciples.Principle_LSP;
using CSharpFundamentals.Core.SOLIDPrinciples.SOLID_Principle_OCP;
using static CSharpFundamentals.Core.SOLIDPrinciples.SOLID_Principle_OCP._02_SOLID_Pricinciple_OCP;

namespace CSharpFundamentals
{
    public static class Day20_SOLID_Principles
    {
        public static void ExecuteSOLID_PricipleOCP()
        {
            var rectangle = new Rectangle { Width = 5, Height = 10 };
            var square = new Square { Side = 7 };

            var areaCalculator = new AreaCalculatorCorrect();

            double rectangleArea = areaCalculator.CalculateArea(rectangle);
            double squareArea = areaCalculator.CalculateArea(square);

            Console.WriteLine($"Rectangle Area: {rectangleArea}");
            Console.WriteLine($"Square Area: {squareArea}");
        }

        public static void ExecuteSOLID_PricipleLSP()
        {
            HumanWorker humanWorker = new HumanWorker();
            humanWorker.EatLSP();
            humanWorker.EatLSP();
            humanWorker.WorkLSP();

            RobotWorker robotWorker = new RobotWorker();
            robotWorker.WorkLSP();

        }
    }
}
