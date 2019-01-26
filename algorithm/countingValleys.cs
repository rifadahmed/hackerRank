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

            var str = Console.ReadLine();
            int[] ar = new int[str.Length];
            int sum = 0,count=0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='D')
                {
                    sum = sum - 1;
                    ar[i] = sum;
                }
                else if (str[i] == 'U')
                {
                    sum = sum + 1;
                    ar[i] = sum;
                }
            }
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]<0 && ar[i+1]==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
            }
        }
    }



