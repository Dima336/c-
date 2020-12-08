using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Garage
    {
        public List<Cars> Cars1 = new List<Cars>();

        public void AddNewCar()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.Write("\nВведите название машины: ");
            name = Console.ReadLine();

            Console.Write("Введите цвет машины: ");
            color = Console.ReadLine();

            Console.Write("Введите скорость машины: ");
            while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
            {
                Console.Write("Введите правильное значение скорости: ");
            }

            Console.Write("Напиишите год выпуска автомобиля: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year > 2020 || year < 1800)
            {
                Console.Write(" Введите правильный год: ");
            }

            Cars newCar = new Cars(name, color, speed, year);

            Cars1.Add(newCar);
        }

        public void DisplayCars()
        {
            int i = 1;
            foreach (Cars c in Cars1)
            {
                Displaycar(c);
                i++;
            }
        }

        public void RemoveCar()
        {
            int position;
            Console.Write("Выберите машину для удаления : ");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > Cars1.Count)
            {
                Console.Write("На этой позиции нет машин. Позиция: ");
            }
           Cars1.RemoveAt(position - 1);
            Console.WriteLine("Автомобиль на позиции {0} удален", position);
        }

        public void SearchByOneCharacteristic(char harakteristika)
        {
            int i = 0;
            switch (harakteristika)
            {
                case 'h':
                    Console.Write("Какое имя автомобиля вы бы хотели найти: ");
                    string name = Console.ReadLine();

                    foreach (Cars c in Cars1)
                    {
                        if (c.Name == name)
                        {
                            Displaycar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Совпадений не найдено.");
                    i = 0;
                    break;

                case 'e':
                    Console.Write("Какой цвет вы бы хотели найти: ");
                    string color = Console.ReadLine();
                    foreach (Cars c in Cars1)
                    {
                        if (c.Color == color)
                        {
                            Displaycar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Совпадений не найдено.");
                    i = 0;
                    break;

                case 'o':
                    Console.Write("Какое имя вы бы хотели найти: ");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    foreach (Cars c in Cars1)
                    {
                        if (c.Speed == speed)
                        {
                            Displaycar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Совпадений не найдено.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("Какое имя вы бы хотели найти: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    foreach (Cars c in Cars1)
                    {
                        if (c.YearofIssue == year)
                        {
                            Displaycar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Совпадений не найдено.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Такой характеристики нет.");
                    break;
            }

        }

        public void Displaycar(Cars car)
        {
            Console.WriteLine("\nИмя  : {0}\nКолор  : {1}\nСкорость  : {2}\nГод  : {3}", car.Name, car.Color, car.Speed, car.YearofIssue);
        }
    }
}