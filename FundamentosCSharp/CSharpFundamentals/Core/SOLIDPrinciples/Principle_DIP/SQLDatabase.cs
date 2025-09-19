using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.Principle_DIP
{
    // Low-level module
    public class SQLDatabase : ISQLDatabase
    {


        //Reemplace old method for an interface 

        /*public string GetData()
        {
            return "Data from SQL Server";
        }*/
        public string GetData()
        {
            return "Data from SQL Server";
        }
    }
}
