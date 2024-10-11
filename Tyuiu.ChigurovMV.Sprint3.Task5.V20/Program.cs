
using Tyuiu.ChigurovMV.Sprint3.Task5.V20.Lib;

namespace Tyuiu.ChigurovMV.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Чигуров М. В. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Чигуров Максим Владиславович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда по формуле        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue1, startValue2 = startValue1 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;
            int x = 5; 
            Console.WriteLine("* Старт суммы первого ряда = " + startValue1);
            Console.WriteLine("* Старт суммы второго ряда = " + startValue2);
            Console.WriteLine("* Конец суммы первого ряда = " + stopValue1);
            Console.WriteLine("* Конец суммы второго ряда = " + stopValue2);
            Console.WriteLine("* Переменная Х = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2);
            Console.WriteLine("* Сумма сумм ряда = " + res);
        }
    }
}
