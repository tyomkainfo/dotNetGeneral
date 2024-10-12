using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Triangle : Figure
    {
        public double Height { get; set; }

        public Triangle(double baseSide, double height) : base(baseSide)
        {
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * Side * Height;
        }

        public override string ToString()
        {
            return "Треугольник с основанием " + Side + " и высотой " + Height + ", площадь: " + GetArea();
        }
    }
}
