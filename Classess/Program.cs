using System;
using System.Threading;

namespace Classess
{
    class Program
    {
        static void Main(string[] args)
        {
            Wave A = new Wave(2);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(A.Waving());
                A.length++;
                Thread.Sleep(500);
            }
            Console.WriteLine("           Hello World!");
            Console.ReadKey();
        }
    }
}
