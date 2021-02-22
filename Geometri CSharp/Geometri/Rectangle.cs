
namespace Geometry
{
    public class Rectangle : Shape
    {
        public Rectangle(double a, double b)
            : base(a, b)
        {
        }

        public override double GetCircumference()
        {
            return (A * 2) + (B * 2);
        }
        public override double GetArea()
        {
            return A * B;
        }
    }
}