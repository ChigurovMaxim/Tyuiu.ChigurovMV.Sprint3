namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            int c = 6;
            int d = 7;

            for (int i = 1; i < 5; i++)
            {
                a++;
                b += c;
                c -= a;
                d = (b - c) + i;
            }
            Console.WriteLine(d);
        }
    }
}
