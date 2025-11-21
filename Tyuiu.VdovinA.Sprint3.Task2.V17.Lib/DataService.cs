using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VdovinA.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            int z = 2; // значение z по условию задачи

            do
            {
                double denominator = Math.Cos(k) + z;
                if (Math.Abs(denominator) < 0.0001) // Защита от деления на ноль
                {
                    denominator = 0.0001;
                }
                double term = 1.0 / denominator;
                sum += Math.Pow(term, 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}