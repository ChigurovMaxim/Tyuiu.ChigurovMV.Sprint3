using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChigurovMV.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double a = 0.25;
            int start = 1;
            int stop = 8;

            double res = 1;
            for (int i = start; i <= stop; i++)
            {
                res *= (Math.Pow(a, i) + 4) * Math.Cos(a);
            }
            return Math.Round(res,3);
        }
    }
}
