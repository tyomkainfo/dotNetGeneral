using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Square : Figure
    {
        public double A { set; get; }
        public Square(double a) 
        {
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override string ToString()
        {
            return "Квадрат со стороной " + A + ", площадь: " + GetArea();
        }
    }
}
