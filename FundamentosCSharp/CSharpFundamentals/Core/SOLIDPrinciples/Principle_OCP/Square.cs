using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.SOLID_Principle_OCP
{
    public class Square : IShape
    {
        public double Side { get; set; }
        public double CalculateArea()
        {
            return Math.Pow(Side,2);
        }
    }
}
