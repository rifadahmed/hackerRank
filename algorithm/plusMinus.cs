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
           
            var a =Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(a, int.Parse);
            double pos=0, neg=0, zero=0;

            for (int i = 0; i < ar.Length; i++)
            {

                if (ar[i] > 0)
                {
                    pos++;
                }
                else if (ar[i] < 0)
                {
                    neg++;
                }
                else
                    zero++;
            }
            Console.WriteLine("{0:0.000000}\n{1:0.000000}\n{2:0.000000}",pos/ar.Length,neg/ar.Length,zero/ar.Length);
            
            //Console.WriteLine(count);
            Console.ReadLine();
            }
        }
    }



