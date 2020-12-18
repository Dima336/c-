using System;
using System.Collections.Generic;

namespace lab_11
{
    delegate void mydelegate(Parkvidvidyvach delegate1);
    delegate bool StudentPredicateDelegate(Student student);

    class Program
    {
        public static void printListStudent(in List<Student> ls)
        {
            foreach(var student in ls)
            {
                Console.WriteLine($"FirstName - {student.FirstName}");
                Console.WriteLine($"LastName - {student.LastName}");
                Console.WriteLine($"Age - {student.Age}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Завдання 1
            Parkvidvidyvach n = new Parkvidvidyvach();
            Parkrozvag m = new Parkrozvag();
            mydelegate delegaterorvag = new mydelegate(m.IPokatavsyanaGirkah);
            delegaterorvag += m.IPostilyavvTire;
            delegaterorvag += m.IShodivVkimnatyStrahy;
            delegaterorvag += m.IShovivVkimnatyKrivDzerk;
            delegaterorvag += m.Iziyvpopkorn;
            delegaterorvag += m.IPokatavsyanachortovomykolesi;
            delegaterorvag(n);
            n.showInfo();
            //Завдання 2

            List<Student> group = new List<Student>();
            group.Add(new Student("Vlad", "Osmak", 18));
            group.Add(new Student("Bohdan", "Student", 19));
            group.Add(new Student("Dima", "Vdovin", 21));
            group.Add(new Student("Vadim", "Kalich", 17));
            group.Add(new Student("Atamas", "Onton", 19));
            group.Add(new Student("Valera", "Bilous", 17));
            group.Add(new Student("Artem", "Iluchenko", 18));
            group.Add(new Student("Vitalik", "Byharik", 18));
            group.Add(new Student("Edik", "Koliu", 18));
            group.Add(new Student("Andrew", "Oshy", 18));


            List<Student> results = new List<Student>();
            StudentPredicateDelegate del;

            //Завдання 2.8
            Console.WriteLine();
            del = Student.isAge18;
            results =  group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = Student.isFirstNameBeginFromA;
            results = group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = Student.isLastNameLengthMoreThan3;
            results = group.FindStudent(del);
            printListStudent(in results);

            //Завдання 2.9
            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.Age >= 18;
            results = group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = student => student.FirstName.ToCharArray()[0] == 'A';
            results = group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = student => student.FirstName.Length > 3;
            results = group.FindStudent(del);
            printListStudent(in results);

            //Завдання 2.10
            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.Age >= 20 && student.Age <= 25;
            results = group.FindStudent(del);
            printListStudent(in results);

            //Завдання 2.11
            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.FirstName == "Andrew";
            results = group.FindStudent(del);
            printListStudent(in results);

            //Завдання 2.12
            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.LastName == "Troelsen";
            results = group.FindStudent(del);
            printListStudent(in results);

            Console.ReadKey();
        }
    }
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> ls, StudentPredicateDelegate del)
        {
            List<Student> tempList = new List<Student>();
            foreach (var student in ls)
            {
                if (del.Invoke(student))
                    tempList.Add(student);
            }
            return tempList;
        }
    }
}
