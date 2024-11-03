using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLibrary;

namespace ConsoleAppTester
{
    internal class Program
    {
        static void printArray(Person[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {

            #region Работа с массивами
            Person[] group = new Person[6];
            group[0] = new Person(true,"Иванов");
            group[1] = new Person(true, "Петров");
            group[2] = new Person(true, "Сидоров");
            group[3] = new Person(true, "Кузнецов");
            group[4] = new Person(true, "Амосов");
            group[5] = new Person(true, "Кузнецов");
            Console.WriteLine("Содержимое массива group до сортировки");
            printArray(group);
            Console.WriteLine("Сравниваем два єлемента между собой. Они одинаковіе");
            //способ 1 - условная инструкция, нужен переопределнній оператор == в классе Person
            if (group[3] == group[5])// сравнение єлементов массива! сравниваются обїекті в памяти
            {
                Console.WriteLine("совпадают group[3] и group[5] Кузнецов");
            }
            else
            {
                Console.WriteLine("Не совпадают ");
            }
            //способ 2 используя методі массивов нуже IEquatable
            int index = Array.IndexOf(group, new Person(true, "Кузнецов"));
            Console.WriteLine("Индекс элемента с фамилией Кузнецов " + index);
            Array.Sort(group);// IComparable
            Console.WriteLine("Содержимое массива group после сортировки");
            printArray(group);
            if (Array.BinarySearch(group, "Кузнецов") >= 0)
            {
                Console.WriteLine("Кузнецов найден");
            }
            else
            {
                Console.WriteLine("Кузнецов не найден");
            }
            #endregion
            #region Работа с персонами
            // new - выделить память под объект и создать его в начальном состоянии при помощи конструктора
            // new ИМЯ_КОНСТРУКТОРА(ПАРАМЕТРЫ)
            Console.WriteLine("Содержимое переменной man");
            Man man = new Man(); // класс, делегат, интерфейс, массив - reference types
            man.setAge(25); // через вызов сеттера
            man.Age = 25; // через свойство, разрешает присвоение
            Console.WriteLine(man.ToString()); // вывод информации о man

            Person person = new Person(true, "Ivan Petrov");
            // person.age = 30; // пришло от родителя Man
            person.name = "Иван"; // появилось от Person
            Console.WriteLine("Содержимое переменной person");
            Console.WriteLine(person.ToString()); // вывод информации о person
            #endregion
            #region Работа с фигурами
            // Создание и вывод фигур
            double a = Math.PI; // int, double, char, bool, DateTime are value types
                                // MathHelper mathHelper = new MathHelper();
            Console.WriteLine("Содержимое переменной a");
            Console.WriteLine(a);
            double circleArea = MathHelper.GetCircleArea(10); // не нужен new MathHelper

            Square square = new Square(4);
            Console.WriteLine(square.ToString());

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.ToString());

            Triangle triangle = new Triangle(3, 4,5);
            Console.WriteLine(triangle.ToString());
            #endregion
            Console.ReadKey(); // pause
        }
    }
}
