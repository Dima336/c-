using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.Write("Введите величину первого сопротивления(Ом)");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите величину второго сопротивления(Ом)");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите величину третьего сопротивления(Ом)");
            c = double.Parse(Console.ReadLine());
            double sum;
            sum = a + b + c;
            Console.Write(sum + " - Сопротивление цепи (последовательное соединение) ");
        }
    }
}