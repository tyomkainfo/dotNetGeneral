using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLibrary
{
    public class Figure
    {
        // public double Side { get; set; }
        /*
        private double side;
        public double Side { get {return side}; set {this.side = value}; }
         */ 

        public virtual double GetArea()
        {
            return 0;
        }

    
    }
}
