using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VdovinA.Sprint3.Task0.V19.Lib
{
    public class DataService : ISprint3Task0V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                sum += 1 / (Math.Cos(k) + 2);
            }

            return Math.Round(sum, 3);
        }
    }
}