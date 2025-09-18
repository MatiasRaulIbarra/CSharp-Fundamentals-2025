using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;

namespace CSharpFundamentals.Core.SOLIDPrinciples.SOLID_Principle_OCP
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Height * Width;
        }

        
    }
}
