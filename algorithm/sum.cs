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
            var x = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(x, int.Parse);
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                sum += ar[i];
            }

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}

