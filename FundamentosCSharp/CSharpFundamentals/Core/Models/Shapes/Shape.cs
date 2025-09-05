namespace CSharpFundamentals.Core.Models.Shapes
{
    public abstract class Shape
    {
        public  string Name { get; }

        public abstract double CalculateArea();
        
    }
}
