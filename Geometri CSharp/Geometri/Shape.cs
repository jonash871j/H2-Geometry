namespace Geometry
{
    public abstract class Shape
    {
        public double A { get; set; }
        public double B { get; set; }

        public Shape(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract double GetCircumference();
        public abstract double GetArea();
        public override string ToString()
        {
            return $": O = {GetCircumference()} | A = {GetArea()}";
        }
    }
}
