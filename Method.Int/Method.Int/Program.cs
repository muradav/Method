using System;

namespace Method.Int
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(12, 13);
            Console.WriteLine(result);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
