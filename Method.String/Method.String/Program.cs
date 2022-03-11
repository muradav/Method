using System;

namespace Method.String
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = Info("Murad", "Valiyev", 28);
            Console.WriteLine(info);
        }

        static string Info(string name, string surname, int age)
        {
            return $"{name} {surname} {age}";
        }
    }
}
