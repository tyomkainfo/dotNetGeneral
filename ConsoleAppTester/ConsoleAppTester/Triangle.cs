using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Triangle : Rectangle
    {
        public double C { get; set; }

        public Triangle(double a, double b, double c) : base(a, b)
        {
            C = c;
        }

        public override double GetArea()
        {
            return MathHelper.GetTriangleArea(A, B, C);
        }

        public override string ToString()
        {
            return "Треугольник с сторонами " + A + "  " + B + ","+ C+ " площадь: " + GetArea();
        }
    }
}
