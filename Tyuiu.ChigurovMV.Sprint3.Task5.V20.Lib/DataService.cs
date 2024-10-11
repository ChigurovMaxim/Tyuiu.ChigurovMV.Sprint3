using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ChigurovMV.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            int i, k;
            double sum = 0;
            for (i = startValue1; i <= 3; i++)
            {
                for (k = startValue2; k <= 6; k++)
                {
                    sum += Math.Pow(x / Math.Sin(x), k);
                }
            }
            return Math.Round(sum,3);
        }
    }
}
