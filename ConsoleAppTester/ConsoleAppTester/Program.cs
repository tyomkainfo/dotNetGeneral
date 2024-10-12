using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Math.PI; // int, double, char, bool, DateTime are value types
            // MathHelper mathHelper = new MathHelper();
            double circleArea = MathHelper.GetCircleArea(10); // не нужен new MathHelper
            Man man = new Man(); // класс, делегат, интерфейс, массив - reference types

            // new - выделить память под объект и создать его в начальном состоянии при помощи конструктора
            // new ИМЯ_КОНСТРУКТОРА(ПАРАМЕТРЫ)
            Console.WriteLine("Содержимое переменной a");
            Console.WriteLine(a);
            Console.WriteLine("Содержимое переменной man");

            man.setAge(25); // через вызов сеттера
            man.Age = 25; // через свойство, разрешает присвоение
            Console.WriteLine(man.ToString()); // вывод информации о man

            Person person = new Person(true, "Ivan Petrov");
            // person.age = 30; // пришло от родителя Man
            person.name = "Иван"; // появилось от Person
            Console.WriteLine("Содержимое переменной person");
            Console.WriteLine(person.ToString()); // вывод информации о person

            // Создание и вывод фигур
            Square square = new Square(4);
            Console.WriteLine(square.ToString());

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.ToString());

            Triangle triangle = new Triangle(3, 6);
            Console.WriteLine(triangle.ToString());

            Console.ReadKey(); // pause
        }
    }
}
