using System;

namespace Method.Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Subtract(10));
        }

        static int Subtract(int num1, int num2=6)
        {
            return num1 - num2;
        }
    }
}
