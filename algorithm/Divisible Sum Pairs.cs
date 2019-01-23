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
            var x = (Console.ReadLine().Split(' '));
            var intgr1 = Array.ConvertAll(x, int.Parse);
            var y = Console.ReadLine().Split(' ');
            int sum = 0, countNum = 0, i, j;
            var intgr2 = Array.ConvertAll(y, int.Parse);
            for (i = 0; i < intgr1[0]; i++)
            {
                for (j = i + 1; j < intgr1[0]; j++)
                {
                    sum = intgr2[i] + intgr2[j];
                    if (sum % intgr1[1] == 0)
                    {
                        countNum++;
                    }
                }
            }
            Console.WriteLine(countNum);


            Console.ReadLine();
        }
    }
}

