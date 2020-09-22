using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            double S = 0, k = 0, o = 0, l = 0;
            double seredne = 0;
            Console.Write("Введите количество строк \n");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов \n");
            m = int.Parse(Console.ReadLine());
            double[,] a = new double[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("m[" + i + "]n[" + j + "] = ");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; ++j)
                {
                    k++;
                    S += a[i, j];
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            seredne = S / k;
            Console.Write(S + "-Сума елементов массива \n");
            Console.Write(k + "-Количество елементов массива \n");
            Console.Write(seredne + "-Среднее арифметическое массива \n");
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (a[i, j] > seredne)
                    {
                        Console.Write(a[i, j] + " ");
                        o++;
                    }
                }
            }
            Console.Write("елементы  которые больше чем среднее арифметисекое  в массиве \n");
            Console.WriteLine();
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (a[i, j] < seredne)
                    {
                        Console.Write(a[i, j] + " ");
                        l++;
                    }
                }
            }
            Console.Write("елементы  которые меньше чем среднее арифметисекое  в массиве \n");
            Console.WriteLine();
            Console.Write(o + "-количество елементов  которые больше чем среднее арифметисекое  в массиве \n");
            Console.WriteLine();
            Console.Write(l + "-количество елементов которые меньше  чем среднее арфметическое  в массиве \n");
        }
    }
}
