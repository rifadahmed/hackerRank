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
            ReadLine();
            var str = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(str, int.Parse);
            int max = 0,count=0;
            for(int i=0;i<ar.Length;i++)
            {
                if(max<ar[i])
                {
                    max = ar[i];
                }
            }
            for(int i=0;i<ar.Length;i++)
            {
                if(max==ar[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
            }
        }
    }



