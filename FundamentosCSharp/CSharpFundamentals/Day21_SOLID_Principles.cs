using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;
using CSharpFundamentals.Core.SOLIDPrinciples.Principle_DIP;

namespace CSharpFundamentals
{
    public static class Day21_SOLID_Principles
    {
        public static void ExecuteSOLID_PricipleDIP()
        {

            ISQLDatabase _SQLDatabase = new SQLDatabase();
            ReportGenerator reportGenerator = new ReportGenerator(_SQLDatabase);
            var data = reportGenerator.GenerateReport();
            Console.WriteLine("SOLID Principle  DIP ");
            Console.WriteLine($"{data}");

        }
    }
}
