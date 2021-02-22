using System;

namespace Geometry
{
    public class Triangle : Shape
    {
        public double C { get; set; }

        public Triangle(double a, double b) : base(a, b)
        {
            C = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public override double GetArea()
        {
            return 0.5 * A * B;
        }

        public override double GetCircumference()
        {
            return A + B + C;
        }
    }
}