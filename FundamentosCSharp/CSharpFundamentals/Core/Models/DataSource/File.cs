using CSharpFundamentals.Core.Interfaces.Data;

namespace CSharpFundamentals.Core.Models.DataSource
{
    public class File : IReadable
    {
        public void ReadData(string message)
        {
            Console.WriteLine($"{message}a file.");
        }
    }
}
