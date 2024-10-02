namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "?d!, 5gh. !!s2";
            string result = "";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    result += c;
                }
            }
            int number = Int32.Parse(result);
            Console.WriteLine(number);
        }
    }
}
