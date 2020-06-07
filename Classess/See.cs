using System;
using System.Collections.Generic;
using System.Text;

namespace Classess
{
    public class See
    {
        public List<Wave> waves;
        public Random rand;
        
        public See(int size)
        {
            rand = new Random();

            for (int i = 0; i < size; i++)
            {
                waves.Add(new Wave(rand.Next(0, 5)));
            }
        }

        public void Tick()
        {
            foreach(Wave w in waves)
            {

            }
        }
    }
}
