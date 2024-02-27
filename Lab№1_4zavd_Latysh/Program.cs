using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_4zavd_Latysh
{
    class Program
    {
        private static void PrintUsage()
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним.");
            Console.Write("Поки вони матимуть вигляд");
            Console.Write(" 0 x ");
            Console.Write("чи");
            Console.Write(" 1 x ");
            Console.Write("чи");
            Console.WriteLine(" 2 x ");
            Console.WriteLine("(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа),");
            Console.WriteLine("програма обчислюватиме одну з трьох функцій");
            Console.WriteLine("\t0 -- sqrt(abs(x))");
            Console.WriteLine("\t1 -- x^3 (інакше кажучи, x*x*x)");
            Console.WriteLine("\t2 -- x + {0}", 3.5);
            Console.WriteLine("(згідно цифри на початку) і виводитиме результат.");
            Console.WriteLine("\nЯкщо вхідний рядок не задовольнятиме цей формат, програма завершить роботу.\n");
        }
        static void Main(string[] args)
        {
            PrintUsage();
            Func<double, double>[] arr = new Func<double, double>[3]
            {
                  (double x) => Math.Sqrt(Math.Abs(x)),
                  (double x) => Math.Pow(x, 3.0),
                  (double x) => x + 3.5
            };
            while (true)
            {
                try
                {
                    string[] arr2 = Console.ReadLine().Trim().Split(' ');
                    Console.WriteLine(arr[int.Parse(arr2[0])](double.Parse(arr2[1])));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Сталася помилка {0}", e.Message);
                    Console.WriteLine("Натисніть будь-яку клавішу для остаточного виходу");
                    Console.ReadKey();
                }
            }
        }
    }
}
