using System;

namespace Geometry
{
    public class Parallelogram : Shape
    {
        public double Angle { get; set; }

        public Parallelogram(double a, double b, double angle)
            : base(a, b)
        {
            Angle = angle;
        }

        public override double GetCircumference()
        {
            return (A * 2) + (B * 2);
        }

        public override double GetArea()
        {
            return A * B * Math.Sin(Angle * 3.1415 / 180);
        }
    }
}