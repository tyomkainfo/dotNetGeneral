﻿using System;
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
        
        public static void MofifyValue(int value)
        {
            //оаботаем с копий переменной А
            value = value + 10 ;// value = value + 1 --> value++
        }
        public static void MofifyValueRef(ref int value)
        {
            //здес работаем с оригиналом - с самой переменной А
            value = value + 10;// value = value + 1 --> value++
        }
        //примитивные типы данных - value types (int, double, char, bool, DateTime)
        //ссылочные типы данных - reference types (классы, делегаты (обїекто-функция, указатель на функцию), интерфейсы, массивы)
        public static void CalcSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;// заполнение той переменной, которая описана где-то в другом месте
            product = a * b;
        }
        //парметр по умолчанию или единственній или последний в списке параметров
        public static void sayHello(string str = "Hello, world!")
        {
            Console.WriteLine(str);
        }
        public static void checkKeys(params string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public bool isGreaterZero(int a)
        {
            // алгоритм
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return a > 0;
        }
        //Func<int, bool> Fuct - делегат, который принимает один параметр int и возвращает bool
        public static void PrintIf(int[] array, Func<int, bool> Fuct)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Fuct(array[i]))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            #region Работа с функциями
            // обічніе параметри - значения by value
            int A = 5;
            MofifyValue(A);//создаем копию переменной А и ее передаем в метод
            //после копию удалили
            //ожидаю увидеть 15? А получу 5
            Console.WriteLine($"Новое значение а = {A}");//сразу одна строка - итоговая
            // Console.WriteLine("Новое значение а = "+a);// concat - method String
            //1) віделится память для строки со значением Новое значение а = 
            //2) для переменной а візовется метод ToString() -
            //віделится память для строкового вида перемнно а
            //3) создаться новая строка с результатом сложения строк
            // параметри по ссылке - ref
            MofifyValueRef(ref A);
            // віходніе параметрі, out
            int S = 0;
            int P = 0;
            CalcSumAndProduct(5, 10, out S, out P);
            Console.WriteLine($"Сумма = {S} Произведение = {P}");
            // параметри по умолчанию
            sayHello();
            // параметі массиві - параметрі переменной длині
            checkKeys("1", "2", "3");
            checkKeys("1");
            checkKeys("1", "2", "3", "6");
            checkKeys();
            // стрелочная функция - лямбда-выражение
            //назначение запись условия в одну строку
            //Fuct - фуктор - предикат
            //последний в списке - тип результата
            // например, Func<int, bool> - принимает int, возвращает bool
            // Func<int, int, int> - принимает два int, возвращает int
            // => - лямбда-оператор сокращеній синтаксис функции
            // параметрі => тело функции - команда return
            Func<int, bool> isXGrZero = a => a > 0;
            Func<int, int, int> summa = (a, b) => a + b;
            Console.WriteLine(isXGrZero(5));
            Console.WriteLine(summa(5, 10));
            Func<int, int> isXLessZero = x => x < 0 ? x : 0;
            int[] array = { -1, -2, -3, 4, 5, 6, 7, 8, 9 };
            int SUMMA = array.Select(x => x < 0 ? x : 0).Sum();
            Console.WriteLine($"Сумма отрицательніх єлементов массива = {SUMMA}");
            SUMMA = array.Sum(isXLessZero);
            PrintIf(array, isXGrZero);
            PrintIf(array, x => x % 2 == 0);
            PrintIf(array, x => x % 2 == 1);
            PrintIf(array, x => x > 0);
            #endregion
            //#region Работа с массивами
            //Person[] group = new Person[6];
            //group[0] = new Person(true,"Иванов");
            //group[1] = new Person(true, "Петров");
            //group[2] = new Person(true, "Сидоров");
            //group[3] = new Person(true, "Кузнецов");
            //group[4] = new Person(true, "Амосов");
            //group[5] = new Person(true, "Кузнецов");
            //Console.WriteLine("Содержимое массива group до сортировки");
            //printArray(group);
            //Console.WriteLine("Сравниваем два єлемента между собой. Они одинаковіе");
            ////способ 1 - условная инструкция, нужен переопределнній оператор == в классе Person
            //if (group[3] == group[5])// сравнение єлементов массива! сравниваются обїекті в памяти
            //{
            //    Console.WriteLine("совпадают group[3] и group[5] Кузнецов");
            //}
            //else
            //{
            //    Console.WriteLine("Не совпадают ");
            //}

            ////способ 2 используя методі массивов нуже IEquatable
            //int index = Array.IndexOf(group, new Person(true, "Кузнецов"));
            //Console.WriteLine("Индекс элемента с фамилией Кузнецов " + index);
            //Array.Sort(group);// IComparable
            //Console.WriteLine("Содержимое массива group после сортировки");
            //printArray(group);
            //if (Array.BinarySearch(group, "Кузнецов") >= 0)
            //{
            //    Console.WriteLine("Кузнецов найден");
            //}
            //else
            //{
            //    Console.WriteLine("Кузнецов не найден");
            //}
            //#endregion
            //#region Работа с персонами
            //// new - выделить память под объект и создать его в начальном состоянии при помощи конструктора
            //// new ИМЯ_КОНСТРУКТОРА(ПАРАМЕТРЫ)
            //Console.WriteLine("Содержимое переменной man");
            //Man man = new Man(); // класс, делегат, интерфейс, массив - reference types
            //man.setAge(25); // через вызов сеттера
            //man.Age = 25; // через свойство, разрешает присвоение
            //Console.WriteLine(man.ToString()); // вывод информации о man

            //Person person = new Person(true, "Ivan Petrov");
            //// person.age = 30; // пришло от родителя Man
            //person.name = "Иван"; // появилось от Person
            //Console.WriteLine("Содержимое переменной person");
            //Console.WriteLine(person.ToString()); // вывод информации о person
            //#endregion
            //#region Работа с фигурами
            //// Создание и вывод фигур
            //double a = Math.PI; // int, double, char, bool, DateTime are value types
            //                    // MathHelper mathHelper = new MathHelper();
            //Console.WriteLine("Содержимое переменной a");
            //Console.WriteLine(a);
            //double circleArea = MathHelper.GetCircleArea(10); // не нужен new MathHelper

            //Square square = new Square(4);
            //Console.WriteLine(square.ToString());

            //Rectangle rectangle = new Rectangle(5, 10);
            //Console.WriteLine(rectangle.ToString());

            //Triangle triangle = new Triangle(3, 4,5);
            //Console.WriteLine(triangle.ToString());
            //#endregion
            Console.ReadKey(); // pause
        }
    }
}
