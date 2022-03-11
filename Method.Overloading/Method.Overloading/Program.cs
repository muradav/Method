using System;

namespace Method.Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5)); 
        }

        static int Sum(int num1)
        {
            return num1;
        }

        static string Sum(string num1, int num2)
        {
            return num1;
        }

        
        //methodlarin parametrlerinin sayi ferqlidir
        //methodlarin parametrlerini type'i ferqlidir
    }
}
