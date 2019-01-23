using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace RectangleApplication
{
    class program
    {
        static void Main(string[] args)
        {

            // string str;

            var str = Console.ReadLine().Split(':');


            var flag1 = str[2].Contains("PM");
            str[2] = str[2].Replace("PM", "");

            var flag2 = str[2].Contains("AM");
            str[2] = str[2].Replace("AM", "");

            var ar = Array.ConvertAll(str, int.Parse);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(flag1);
            //Console.WriteLine(flag2);




            if (flag1 == true && ar[0] != 12)
            {
                ar[0] = ar[0] + 12;

            }
            if (flag2 == true && ar[0] == 12)
            {
                ar[0] = 0;

            }
            Console.WriteLine(string.Format("{0:00}:{1:00}:{2:00}", ar[0], ar[1], ar[2]));
            Console.ReadLine();
        }
    }
}



