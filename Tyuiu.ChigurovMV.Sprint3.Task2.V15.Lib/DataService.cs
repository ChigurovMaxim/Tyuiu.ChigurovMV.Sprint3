using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChigurovMV.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = 0.5;
            int start, i = 1;
            int stop = 20;
            double sum = 0;
            do
            {
                sum += (Math.Pow(a, i) + 0.5) * Math.Cos(i);
                i++;
            } while (i <= stop);
            return Math.Round(sum, 3);
        }
    }
}
