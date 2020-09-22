using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x1, y1, x2, y2;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());


            if ((x > x1) && (x < x2) && (y < y1) && (y > y2))
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}