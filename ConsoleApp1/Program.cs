using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(2, 3);
            Console.ReadKey();
        }
    }

    // объявление нового класса
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Сумма {x} и {y} равна {z}");
        }
    }
}