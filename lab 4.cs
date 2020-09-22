using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a;
            a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("element masiva #" + (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 1; i < n - 1; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                    a[i] = a[n - 1] + a[i];
                }
                if (i % 2 != 0)
                {
                    Console.Write(a[i] + " ");
                    a[i] = a[0] + a[i];
                }
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}