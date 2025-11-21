using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VdovinA.Sprint3.Task2.V17.Lib
{
    public class DataService : ISprint3Task2V17
    {
        public double GetSumSeries(int value)
        {
            double sum = 0;
            int k = 1;

            do
            {
                double denominator = Math.Cos(k) + value;
                if (Math.Abs(denominator) < 0.0001) // Защита от деления на ноль
                {
                    denominator = 0.0001;
                }
                double term = 1.0 / denominator;
                sum += Math.Pow(term, 2);
                k++;
            } while (k <= 10);

            return Math.Round(sum, 3);
        }
    }
}