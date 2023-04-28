using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = 2.0;
            double c = a + b;
            c = ++b; //b++ darebbe 2
            a += 5;
            int d = Int32.Parse("5");
            Console.WriteLine(c);
            int e = Math.Abs(-40);
            double f = Math.Pow(5,2);
        }
    }
}