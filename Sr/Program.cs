// Вдовін Дмитро Едуардович ПД-22
using System;

namespace sr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 4 \n\n");

            var cars = new Cars();
            bool exist = true;

            string color;
            int yearOfMade = 0;
            int price = 0;
            int enginePower = 0;

            byte amount = 0;
            string tempForInput;

            Console.WriteLine("Приветсвую Вас в магазине");
            Console.WriteLine("Хотите  выбрать машину по параметрах?");
            Console.WriteLine(" y= Да хочу, n= Нет не хочу покажите мне все машини которие у вас есть");
            Console.Write("Введите y или n: ");
            tempForInput = Console.ReadLine();

            if (tempForInput == "y")
            {
                while (exist)
                {
                    amount = 0;
                    color = null;
                    tempForInput = null;
                    Console.WriteLine();
                    Console.WriteLine("-Выберите машину по параметрам");
                    Console.Write("Цвет");
                    Console.Write("Язык на английском");
                    Console.Write(" Год производства, Цена и Мощность двигателя \n");
                    Console.Write("-Если ви хотите пропустить характеристику введите - \n\n");
                    Console.Write("Введите цвет  авто: ");
                    color = Console.ReadLine();
                    if (color == "-")
                        amount++;
                    Console.Write("Введите год производства: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else yearOfMade = Convert.ToInt32(tempForInput);
                    Console.Write("Введите цену: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else price = Convert.ToInt32(tempForInput);
                    Console.Write("Введите  мощность двигателя: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else enginePower = Convert.ToInt32(tempForInput);
                    cars.findCar(amount, color, yearOfMade, price, enginePower);
                    Console.WriteLine("\nМне не нравятся эти машини хочу вибрать еще раз! ");
                    Console.WriteLine("Да, Нет(Виход из программи)");
                    Console.Write("Введите y или n: ");
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "y" ? true : false;
                }
            }
            else
            {
                cars.showInfoAboutCars();
                Console.WriteLine();
                exist = false;
            }

        }
    }
}