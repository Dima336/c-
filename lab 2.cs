
using System;
class HelloWorld
{
    static void Main()
    {
        Console.Write("Введите ваше nn");
        double nn;
        Console.Write("Введите ваше nk");
        double nk;
        nn = double.Parse(Console.ReadLine());
        nk = double.Parse(Console.ReadLine());
        decimal result = 0;
        for (int k = (int)(nn); k <= nk; k++)
        {
            result += (decimal)((Math.Pow(-1, k) * k * k - 1) / (k * k + 3));
        }
    Console.Write(result +"Ответ");
  }
}