using System;


namespace AnyShape
{
    public interface IAnyShape
    {
        double Area { get; }
    }
    public class Circle : IAnyShape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = default(byte);

        }
        public Circle(double radius)
        {
            Radius = radius;

        }
        public double Area
        {
            get
            {                          // S = pi*r2   // Площадь круга
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
    }

    public class Triangle : IAnyShape                                
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {
            A = B = C = default(byte);
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Area
        {
            get
            {
                double p = (A + B + C) / 2;                     
                double t = p * (p - A) * (p - B) * (p - C);
                double S= Math.Sqrt(t);                                   // Площадь треугольника // Area of triangle
                return S;
            }
        }
        public bool IsRightTriangle()                    // проверка на прямой угол // Right angle check
        {
            double a2 = A * A;
            double b2 = B * B;
            double c2 = C * C;
            double s2 = (a2 + b2 + c2) / 2;
            return s2 == c2 || s2 == b2 || s2 == a2;

        }
    }
    public class XShape : IAnyShape       // Любая фигура
    {
        private IAnyShape shape;
        public XShape(IAnyShape figure)
        {
            shape = figure;
        }
        public double Area
        {
            get
            {
                return shape.Area;
            }
        }

    }
}
