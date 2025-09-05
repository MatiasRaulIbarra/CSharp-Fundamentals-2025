using System.Reflection.Metadata.Ecma335;

namespace CSharpFundamentals.Core.Models.Validators
{
    public static class DataValidator
    {
        public static   bool IsValidEmail(string email)
        {
           return email.Contains("@") && email.Contains(".");
        }
        

        public static bool IsPositiveNumber(int number)
        {
            return number > 0;
        }
    }  
}
