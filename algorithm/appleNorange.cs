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
            //int n = Convert.ToInt32(Console.ReadLine());

            int s, t, a, b, count1 = 0, count2 = 0;

            var str1 = Console.ReadLine().Split(' '); //S T
            var ar1 = Array.ConvertAll(str1, int.Parse);

            var str2 = Console.ReadLine().Split(' ');// A B
            var ar2 = Array.ConvertAll(str2, int.Parse);

            ReadLine();

            var str3 = Console.ReadLine().Split(' ');//APPLES
            var ar3 = Array.ConvertAll(str3, int.Parse);

            var str4 = Console.ReadLine().Split(' ');//ORANGES
            var ar4 = Array.ConvertAll(str4, int.Parse);




            for (int i = 0; i < ar3.Length; i++)
            {
                int loc = ar3[i] + ar2[0];
                if (loc >= ar1[0] && loc <= ar1[1])
                {
                    count1++;
                }
            }



            for (int i = 0; i < ar4.Length; i++)
            {
                int loc = ar4[i] + ar2[1];
                if (loc >= ar1[0] && loc <= ar1[1])
                {
                    count2++;
                }

            }

            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.ReadLine();
        }
    }
}

