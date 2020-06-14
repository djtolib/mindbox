using System;

namespace Shapes
{
    public class Shape
    {

        public virtual double Square()
        {
            return -1;
        }
    }
    public class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double Square()
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public bool isRight()
        {
            double hypo = Math.Max(Math.Max(a, b), c);
            return a * a + b * b + c * c - 2 * hypo * hypo == 0;
        }
    }
    public class Circle : Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Square()
        {
            return Math.PI * r * r;
        }
    }
}
