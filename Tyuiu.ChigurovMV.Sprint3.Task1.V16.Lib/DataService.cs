﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChigurovMV.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double x = 0.7;
            int start, i = 1;
            int stop = 15;
            double sum = 0;
            while (i <= stop)
            {
                sum += (Math.Pow(x, 2) * Math.Sin(i)) + 1;
                i++;
            }
            return Math.Round(sum, 3);
        }
    }
}
