using CSharpFundamentals.Core.Interfaces.SOLIDPrinciples;
namespace CSharpFundamentals.Core.SOLIDPrinciples.SOLID_Principle_OCP
{
    public class _02_SOLID_Pricinciple_OCP
    {

        public class RectangleError
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        public class SquareError
        {
            public double Side { get; set; }
        }




        // This class violates the  OCP

        /// <summary>
        /// SECTION 1
        ///The class violates the Open/Closed Principle because a new shape requires
        ///modifying the base class
        /// </summary>
        public class AreaCalculator
        {
            public double CalculateArea(object shape)
            {
                if (shape is RectangleError)
                {
                    RectangleError rect = (RectangleError)shape;
                    return rect.Width * rect.Height;
                }
                else if (shape is SquareError)
                {
                    SquareError square = (SquareError)shape;
                    return square.Side * square.Side;
                }

                throw new ArgumentException("Unsupported shape");
            }
        }




        ///<summary>
        ///Section 2 
        ///Aplication of the Open/Closes Principle
        /// </summary>

        public class AreaCalculatorCorrect  // with the interface we  don't need modify the base class, it's closed for modification
        {
            public double CalculateArea(IShape shape)
            {
                return shape.CalculateArea();
            }


        }


    }
}
