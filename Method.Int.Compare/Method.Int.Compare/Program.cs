using System;

namespace Method.Int.Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compare(23,34));

            
        }

       

        static int Compare(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }


        }

       

    }
}
