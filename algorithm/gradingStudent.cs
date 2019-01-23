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
            int[] ar = new int[n];
            int mod, x;
            for (int i = 0; i < n; i++)
            {
                var y = Convert.ToInt32(Console.ReadLine());
                ar[i] = y;

            }

            for (int i = 0; i < n; i++)
            {
                if (ar[i] >= 38)
                {
                    mod = ar[i] % 5;
                    if (mod >= 3)
                    {
                        x = 5 - mod;

                        Console.WriteLine(ar[i] + x);
                    }
                    else
                    {
                        Console.WriteLine(ar[i]);
                    }
                }
                else
                    Console.WriteLine(ar[i]);

            }

                Console.ReadLine();
            }
        }
    }



