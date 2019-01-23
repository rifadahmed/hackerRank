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
            var n = (Console.ReadLine().Split(' '));

            var ar = Array.ConvertAll(n, int.Parse);
            if (ar[0] == ar[2] && ar[1] == ar[3])
            {
                Console.WriteLine("YES");
            }

            else if ((ar[0] > ar[2] && ar[1] > ar[3]) || (ar[2] > ar[0] && ar[3] > ar[1]) || (ar[0] == ar[2] && ar[1] > ar[3])
               || (ar[0] < ar[2] && ar[1] == ar[3]))
            {
                Console.WriteLine("NO");
            }

            else
            {
                if ((ar[0] - ar[2]) % (ar[3] - ar[1]) == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                    Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }
}

