using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            waves = new List<Wave>();

            for (int i = 0; i < size; i++)
            {
                if (rand.Next(0, 9) < 2)
                    waves.Add(new Wave(rand.Next(0, 15)));
                else waves.Add(new Wave(0, false));
            }
        }

        public void Tick(int time = 500)
        {
            Console.Clear();
            foreach(Wave w in waves) //show all the waves
            {
                //Console.WriteLine(w.active.ToString() + w.startPoint.ToString() + w.length.ToString());
                Console.WriteLine(w.Waving());
                w.length++;
            }

            for (int i = 0; i < size; i++) //replace deactivated with new (20% chance)
            {
                if (!waves[i].active && rand.Next(0, 9) < 2)
                {
                    waves[i] = new Wave(rand.Next(0, 15));
                }
            }

            Thread.Sleep(time); //wait a bit
        }
    }
}
