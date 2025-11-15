using Tyuiu.VdovinA.Sprint3.Task0.V19.Lib;
using System;

namespace Tyuiu.VdovinA.Sprint3.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Вдовин А. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Вдовин А. | ПКТб-25-1                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле S = ∑[k=1 to 10] (1/(cos k + 2))                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            double result = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}