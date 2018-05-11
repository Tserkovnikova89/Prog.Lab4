using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tserkovnikova
{
    public class A
    {
        public int a = 5;
        public int b = 7;
        public int c
        {
            get
            {
                if (a < b) return a;
                else return b;
            }
            set
            {
                while (c != 0)
                {
                    c = value;
                }
            }
        }
        public class B : A
        {
            public int d = 2;

            public int c2
            {
                get
                {
                    return d *= ++d;
                }
            }
        }
        class Programm
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" Церковникова Ксения Сергеевна, Лабораторная работа №4 \n");
                Console.WriteLine(" В рамках консольного приложения разработать класс В – наследник класса А с полем d и свойством с2. \n Свойство с2 – результатвычисления выражения над полями a, b, d.В теле свойства использоватьуправляющий оператор.\n У класса А создатьконструктор, инициализирующий его поля. \n Для класса В определить 2 конструктора: один – наследуется от конструктора класса А, второй – собственный.\n В теле программы создать объекты классов А и В,продемонстрировав работу всех конструкторов.Вывести значения свойства на экран.");
                A obj1 = new A();
                Console.WriteLine(" Ответ 1: " + obj1.c);
                B obj2 = new B();
                Console.WriteLine(" Ответ 2: " + obj2.c2);
            }
        }
    }
}
