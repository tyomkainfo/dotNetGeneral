using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Figure
    {
        public double Side { get; set; }

        public Figure(double side)
        {
            Side = side;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Фигура со стороной " + Side;
        }
    }
}
