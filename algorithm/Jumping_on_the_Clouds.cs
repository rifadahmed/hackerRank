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
            var str = Console.ReadLine().Split(' ');
            var x = Array.ConvertAll(str, int.Parse);
            var ar = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int i, j=x[1],life=100;
            for(i=0;i<ar.Length;)
            {
                if (ar[i] == 1)
                {
                    life = life - 3;
                }
                else
                {
                    life = life - 1;
                }
                i = i + j;
                if(i>ar.Length-1)
                {
                    break;
                }

            }
            Console.WriteLine(life);
            
            Console.ReadLine();

        }
            
            
            }
        }
    



