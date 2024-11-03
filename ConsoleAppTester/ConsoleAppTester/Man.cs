using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTester
{
    // internal все из єтого проекта
    // public все из всех проектов
    // private только внутри класса
    // protected только внутри класса и наследников
    internal class Man // : System.Object .Net 1.0
    {
        //изначльно создано автоматом три метода
        // 1- конструктор по умолчанию - конструктор без параметров - конструктор єто метод, который вызывается при создании объекта
        //при использовании new 
        // 2 - ToString() - метод, который вызывается при попытке вывести объект на консоль в строку (сериализация, отправка на сервер)
        // 3 - Equals() - метод, который вызывается при сравнении объектов (для сортировки Array of Object)
        // 4 - GetHashCode() - метод, который вызывается при попытке получить хеш-код объекта (чтобі обїект біл ключом в Словаре)
        // string phone = myPhoneBook[man];
        // fields - поля, class variables - переменные
        protected int age;// 0 // public плохо. потому. что нет защит и проверок
                          //для каждого свойства - properties
                          //свойства єто не только правила и проверки, єто не только доступ толко для чтения или записи
                          //но єто еще и возможность делать binding - привязку к элементам управления
        public int Age
        {
            get // правило - если свойство только для чтения, то только get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Возраст не может быть отрицательным");
                    return;
                }
                age = value;
            }
        }
        protected bool isMan;//false - по умолчанию true - мужчина, false - женщина
        public bool IsMan { get { return isMan; }  }
        // конструктор по умолчанию
        public Man()
        {
            age = 18;
            isMan = true;
        }

        override public string ToString()
        {
            return "возраст " + age + " мужчина - " + isMan;
        }
        //ооп - инкапсуляция - сокрытие данных, сеттер и геттер
        public void setAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Возраст не может быть отрицательным");
                return;
            }
            this.age = age;
        }
        public int getAge()
        {
            return this.age;
        }


    }
}
