using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Rectangle : Figure
    {
        public double Height { get; set; }

        public Rectangle(double width, double height) : base(width)
        {
            Height = height;
        }

        public override double GetArea()
        {
            return Side * Height;
        }

        public override string ToString()
        {
            return "Прямоугольник с шириной " + Side + " и высотой " + Height + ", площадь: " + GetArea();
        }
    }
}
