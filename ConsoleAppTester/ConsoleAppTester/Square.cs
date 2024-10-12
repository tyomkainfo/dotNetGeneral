using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Square : Figure
    {
        public Square(double side) : base(side)
        {
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override string ToString()
        {
            return "Квадрат со стороной " + Side + ", площадь: " + GetArea();
        }
    }
}
