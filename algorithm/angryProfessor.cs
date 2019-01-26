//author :rifad ahmed
// problem link :https://www.hackerrank.com/challenges/angry-professor
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
            string str = null;
            int count = 0;
            for(int i=0;i<n;i++)
            {
                var ar1 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
                var ar2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for(int j=0;j<ar1[0];j++)
                {
                    if(ar2[j]<=0)
                    {
                        count++;
                    }
                }
                if (count >= ar1[1])
                {
                    str += "NO ";
                }
                else
                {
                    str += "YES ";
                }
                    count = 0;





            }
            var x = str.Split(' ');
           for(int k=0;k<x.Length;k++)
            {
                Console.WriteLine(x[k]);
            }
            


            Console.ReadLine();

        }
            
            
            }
        }
    



