using System;
using System.Collections.Generic;
using System.Text;

namespace Classess
{
    public class Wave
    {
        public int startPoint;
        public int length; //stan
        public bool active;

        public Wave(int _startPoint = 0)
        {
            startPoint = _startPoint;
            length = 0;
            active = true;
        }

        public string Waving()
        {
            string ret = "";
            string spaces = "";

            //adding starting point
            for (int i = 0; i < startPoint; i++)
            {
                spaces += " ";
            }

            //adding movement
            for (int i = 0; i < length; i++)
            {
                spaces += " ";
            }

            ret = spaces;

            switch (length)
            {
                case 1:
                    ret = spaces + "_";
                    break;
                case 2:
                    ret = spaces + "_n";
                    break;
                case 3:
                    ret = spaces + "_/m";
                    break;
                case 4:
                    ret = spaces + "_/\\";
                    break;
                case 5:
                    ret = spaces + "_n";
                    break;
                case 6:
                    ret = spaces + "_";
                    break;
                case 7:
                    ret = spaces + ".";
                    break;
                default:
                    active = false;
                    break;
            }
            
            return ret;
        }
    }
}
