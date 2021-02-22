using System;

namespace Geometry
{
    public class Trapeze : Shape
    {
        public double C { get; set; }
        public double D { get; set; }

        public Trapeze(double a, double b, double c, double d)
            : base(a, b)
        {
            C = c;
            D = d;
        }

        public double GetHeight()
        {
            double s = (A + B - C + D) / 2;
            return (2 / (A - C)) * (Math.Sqrt(s * (s - A + C) * (s - B) * (s - D)));
        }
        public override double GetCircumference()
        {
            return A + B + C + D;
        }
        public override double GetArea()
        {
            return 0.5 * (A + C) * GetHeight();
        }
    }
}
