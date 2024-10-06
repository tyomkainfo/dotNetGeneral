using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal partial class Person: Man// унаследовал структуру inheritance , extends
    {
        public string name;
        public Person(bool sex, string name)
        {
            this.age = 18;
            this.name = name;
            this.isMan = sex;
        }
        private Person()
        {
            this.age = 18;
            this.name = "NONAME";
            this.isMan = true;
        }

    }
}
//ДЗ - делаем иерархию фигур
// Math - сторона, площадь
//square - квадрат
//rectangle - прямоугольник
//triangle - треугольник