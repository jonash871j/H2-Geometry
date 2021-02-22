namespace Geometry
{
    public class Square : Shape
    {
        public Square(double length)
            : base(length, length)
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