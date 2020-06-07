using System;
using System.Collections.Generic;
using System.Text;

namespace Classess
{
    public class See
    {
        public List<Wave> waves;
        public Random rand;
        public int size;
        
        public See(int _size = 10)
        {
            size = _size;
            rand = new Random();

            for (int i = 0; i < size; i++)
            {
                waves.Add(new Wave(rand.Next(0, 15)));
            }
        }

        public void Tick(int time = 500)
        {
            Console.Clear(); //clear window
            foreach(Wave w in waves) //show all the waves
            {
                Console.WriteLine(w.Waving());
                w.length++;
            }

            for (int i = 0; i < size; i++) //replace deactivated with new
            {
                if (!waves[i].active)
                {
                    waves[i] = new Wave(rand.Next(0, 15));
                }
            }
        }
    }
}
