using CSharpFundamentals.Core.Interfaces.Data;

namespace CSharpFundamentals.Core.Models.DataSource
{
    public class DataBase : IReadable
    {
         public void ReadData(string message)
         {
             Console.WriteLine($"{message}database.");
         }
    }
}
