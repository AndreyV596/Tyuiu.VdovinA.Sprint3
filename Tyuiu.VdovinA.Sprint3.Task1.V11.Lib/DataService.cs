using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VdovinA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiply = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                multiply *= (Math.Pow(value, k) + 0.5);
                k++;
            }

            return Math.Round(multiply, 3);
        }
    }
}