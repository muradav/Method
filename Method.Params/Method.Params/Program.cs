using System;

namespace Method.Params
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int result = SumMassiv(1,2,3,4,5);
            Console.WriteLine(result);
        }

        static int SumMassiv(params int[] arr)
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
