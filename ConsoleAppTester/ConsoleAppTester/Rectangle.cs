using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Rectangle : Square
    {
        public double B { get; set; }

        public Rectangle(double a, double b) : base(a)
        {
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override string ToString()
        {
            return "Прямоугольник с шириной " + A + " и высотой " + B + ", площадь: " + GetArea();
        }
    }
}
