using System;
using System.Collections.Generic;

namespace lab_7_dimass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаб. 6 вар. 4");
            List<int> listInt = new List<int>();
            Console.Write("Введите размер листа: ");
            int sizeList = int.Parse(Console.ReadLine());
            for(int i = 0; i < sizeList; i++)
            {
                Console.Write($"Введите {i+1}-ий елемент листа: ");
                listInt.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Введите пероверочную переменную: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Индекси елементов которие имеют значение переверочной перенной: ");
            bool temp = false;
            for (int i = 0; i < sizeList; i++)
            {
                if (listInt[i] == k)
                {
                    Console.Write("{0 } ", i);
                    temp = true;
                }
            }
            if(!temp)
                Console.Write("--Таких елементов нет--");
            int[] ArrFromList = new int[sizeList];
            for (int i = 0; i < sizeList; i++)
                ArrFromList[i] = listInt[i];
            Console.WriteLine();
            Console.Write("Масив по исходному листу: ");
            for (int i = 0; i < sizeList; i++)
                Console.Write($"{ArrFromList[i]} ");
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
