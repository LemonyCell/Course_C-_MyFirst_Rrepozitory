using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class MyRand
    {
        public static Random r = new Random();

        public static int RandNum(int minVal, int MaxVal)
        {
            return (r.Next(minVal, MaxVal));
        }

        public static string RandSrt(int len)
        {

            string s = "";
            for (int i = 0; i < len; i++)
            {
                s += (char)r.Next('a', 'z' + 1);
            }

            return s;
        }

        public static string RandSrtUpper(int len)
        {

            string s = "";
            for (int i = 0; i < len; i++)
            {
                s += (char)r.Next('a', 'z' + 1);
            }

            return s;
        }

    }
}
