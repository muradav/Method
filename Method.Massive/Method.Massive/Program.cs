using System;

namespace Method.Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int result = SumMassive(array);
            Console.WriteLine(result);
        }

        static int SumMassive(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
               sum += item;
            }
            return sum;
        }
    }
}
