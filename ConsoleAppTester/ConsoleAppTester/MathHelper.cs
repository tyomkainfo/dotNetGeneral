using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    //static class - класс, который содержит только статические методы
    //статические методы - методы, которые не требуют создания объекта
    //не требует конструктора - запрет на new
    internal static class MathHelper
    {
        //static - метод принадлежит классу, а не объекту, только функция, не объект
        public static double GetCircleArea(double radius)
        {
            //static функция не нуждается в доступке к полям обїекта, она самодостаточная
            //работает только со своими параметрами
            return Math.PI * radius * radius;
        }
        public static double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
