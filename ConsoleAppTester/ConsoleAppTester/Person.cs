using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    // БЕЗОПАСНІЙ КЛАСС с точки зрения ПРОЕКТИРОВАНИЯ
    //0 есть ли безопасній конструктор по умолчанию
    //1 toString - как єто віглядит для пользователя
    //2 IEquatable - сравнение объектов по каким полям сравниваем для коллекций.Net 4.0+
    //3 equals - сравнение объектов по каким полям сравниваем при помощи уже реализованного IEquatable
    //4 IComparable - сравнение объектов по каким полям сравниваем
    //5 должен реализовать два оператора == и != через Equals для условного операто

    //6 ОПЦИОННО - для красоті кода - если мі разрешаем сравнивать, то >, <, >=, <=

    //7 СКОРЕЕ ВСЕГО НУЖНО, но делать будет сеньор - безопасность с точки зрения ПАМЯТИ
    // + IDispose, ICloneable


    // символ : означае - унаследовал структуру inheritance , extends
    // символ : означае - реализовал интерфейс
    internal partial class Person : Man, IEquatable<Person>, IComparable<Person>
    {
        public string name;
        public Person(bool sex, string name)
        {
            this.age = 18;
            this.name = name;
            this.isMan = sex;
        }
        private Person()// 0 - done
        {
            this.age = 18;
            this.name = "NONAME";
            this.isMan = true;
        }
        public override string ToString()// 1 - done
        {
            return "Имя " + name + " возраст " + age + " мужчина - " + isMan;
        }

        public bool Equals(Person other)//2 - done для сравнения объектов IEquatable
        {
            if (other == null) return false;
            return this.name == other.name && this.age == other.age && this.isMan == other.isMan;
        }

        //берем от родителя System.Object
        public override bool Equals(object obj)//3 - done для сравнения объектов
        {
            return Equals(obj as Person);//обязательно візіваю свой метод
            //as - приведение типов из System.Object в Person
        }
        // Переопределение оператора сравнения на равенство == при помощи своего Equals
        public static bool operator ==(Person left, Person right)
        {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);

            return left.Equals(right);
        }

        // Переопределение оператора сравнение на неравенство != через свой оператор ==
        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
        //ОПЦИОНАЛЬНО синтаксическая красота
        public static bool operator <(Person left, Person right)
        {
            return left.age < right.age;
        }
        public static bool operator >(Person left, Person right)
        {
            return left.age > right.age;
        }
        //

        public int CompareTo(Person other)//4 - done для сравнения объектов IComparable
        {
            // 1 - this > other
            // 0 - this = other
            // -1 - this < other
            if (other == null) return 1;
            int nameComparison = string.Compare(this.name, other.name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            int ageComparison = this.age.CompareTo(other.age);
            if (ageComparison != 0) return ageComparison;
            return this.isMan.CompareTo(other.isMan);
        }
    }
}
//ДЗ - делаем иерархию фигур
// Math - сторона, площадь
//square - квадрат
//rectangle - прямоугольник
//triangle - треугольник