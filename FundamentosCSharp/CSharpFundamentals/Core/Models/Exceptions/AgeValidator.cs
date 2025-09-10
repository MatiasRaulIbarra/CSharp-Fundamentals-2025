namespace CSharpFundamentals.Core.Models.Exceptions
{
    public class AgeValidator
    {
        public void VerifyAge(int age)
        {
            if (age < 0  || age > 115)
            {
                throw new ArgumentException("Age must be between 0 and 115.");
            }
            
        }
    }
}
