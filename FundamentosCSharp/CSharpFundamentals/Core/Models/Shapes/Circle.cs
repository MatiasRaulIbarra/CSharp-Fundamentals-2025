using System.Runtime.CompilerServices;

namespace CSharpFundamentals.Core.Models.Shapes
{
    public class Circle : Shape
    {

        public double radius {  get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
