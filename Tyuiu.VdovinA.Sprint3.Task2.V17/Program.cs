using System;
using Tyuiu.VdovinA.Sprint3.Task2.V17.Lib;

namespace Tyuiu.VdovinA.Sprint3.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Вдовин А. | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Вдовин Андрей| ПКТБ-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет сумму     *");
            Console.WriteLine("* ряда по формуле: S = ∑(k=1 to 10) (1/(cos k + z))²                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int z = 1;
            Console.WriteLine($"Значение z = {z}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(z);
            Console.WriteLine($"Сумма ряда = {result:F3}");

            // Дополнительная информация для отладки
            Console.WriteLine("\nДетали вычислений для z = 1:");
            double debugSum = 0;
            for (int k = 1; k <= 10; k++)
            {
                double term = 1.0 / (Math.Cos(k) + z);
                double squaredTerm = Math.Pow(term, 2);
                debugSum += squaredTerm;
                Console.WriteLine($"k = {k}: cos({k}) = {Math.Cos(k):F3}, член ряда = {squaredTerm:F6}");
            }
            Console.WriteLine($"Итоговая сумма: {debugSum:F3}");

            Console.ReadKey();
        }
    }
}