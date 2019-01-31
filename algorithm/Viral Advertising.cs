//author :rifad ahmed
// problem link :https://www.hackerrank.com/challenges/strange-advertising/
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
            int sum = 0;
            int p = 2;
            int div;
            for(int i=0;i<n-1;i++)
            {
                div = (p * 3) / 2;
                p = div;
                sum += div;
                
               

            }
            sum = sum + 2;
            Console.WriteLine(sum);
            
            Console.ReadLine();

        }
            
            
            }
        }
    



