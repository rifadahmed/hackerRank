//author :rifad ahmed
// problem link :
//my profile : https://www.hackerrank.com/rifad_ahmed

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
            var n = Convert.ToInt32(Console.ReadLine());
            int i, j, x, y, count = 0;
            string store = null;
            for (i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                x = Convert.ToInt32(str);
                for (j = 0; j < str.Length; j++)
                {
                    y = Convert.ToInt32(str[j]) - 48;
                    if (y != 0 && x % y == 0)
                    {
                        count++;
                    }

                }
                store = store + count + "\n";
                count = 0;

            }






            Console.WriteLine(store);
            Console.ReadLine();

        }


    }
}




