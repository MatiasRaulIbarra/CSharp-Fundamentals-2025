namespace CSharpFundamentals.Core.Models.Shapes
{
    public class Square : Shape
    {
        public double side {  get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
