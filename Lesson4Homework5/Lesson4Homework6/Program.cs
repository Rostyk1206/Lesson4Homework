using System;

namespace Lesson4Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your salary:");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Work experience:");
            int year = int.Parse(Console.ReadLine());

            if(year>=0 && year<5)
            {
                double bonus=salary*0.1;
                Console.WriteLine($"Your bonus:{bonus}$");
            }
            if (year >= 5 && year < 10)
            {
                double bonus = salary * 0.15;
                Console.WriteLine($"Your bonus:{bonus}$");
            }
            if (year >= 10 && year < 15)
            {
                double bonus = salary * 0.25;
                Console.WriteLine($"Your bonus:{bonus}$");
            }
            if (year >= 15 && year < 20)
            {
                double bonus = salary * 0.35;
                Console.WriteLine($"Your bonus:{bonus}$");
            }
            if (year >= 20 && year < 25)
            {
                double bonus = salary * 0.45;
                Console.WriteLine($"Your bonus:{bonus}$");
            }
            if (year >= 25 && year < 150)
            {
                double bonus = salary * 0.50;
                Console.WriteLine($"Your bonus:{bonus}$");
            }

        }
    }
}
