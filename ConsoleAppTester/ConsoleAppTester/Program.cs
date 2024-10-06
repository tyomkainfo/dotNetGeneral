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
            double a = Math.PI;// int, double, char, bool, DateTime are value types
            // MathHelper mathHelper = new MathHelper();
            double circleArea = MathHelper.GetCircleArea(10);// не нужен new MathHelper
            Man man = new Man();// класс, делегат, интерфейс, массив - reference types
            // new - віделить паямять под объект и создать его в начальном состоянии при помощи конструктора
            // new ИМЯ_КОНСТРУКТОРА(ПАРАМЕТРЫ)
            Console.WriteLine("Содержимое переменной a");
            Console.WriteLine(a);
            Console.WriteLine("Содержимое переменной man");
       
            man.setAge(25);//через візов сеттера
            man.Age = 25;// через свойство, разрешает присвоение
            Console.WriteLine(man.ToString());// ConsoleAppTester.Man
            string name = man.ToString();
            Person person = new Person(true,"Ivan Petrov");
            // person.age = 30;// пришло от родителя Man
            person.name = "Иван";// появилось от Person
            Console.ReadKey();// pause
          
        }
    }
}
