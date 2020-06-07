using System;
using System.Threading;

namespace Classess
{
    class Program
    {
        static void Main(string[] args)
        {
            See see = new See();
            while (true)
            {
                see.Tick();
            }
        }
    }
}
