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
            ReadLine();
            var x = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(x, int.Parse);
            int i, j, k,n=1;
            int[] aj = new int[ar.Length + 1];
            for( i=0;i<ar.Length;i++)
            {
                for(j=0;j<ar.Length;j++)
                {
                    if(ar[j]==n)
                    {
                        j++;
                        for(k=0;k<ar.Length;k++)
                        {
                            if(ar[k]==j)
                            {
                                aj[i] = k+1;

                            }
                        }

                    }

                }
                n++;


            }

            for(i=0;i<ar.Length;i++)
            {
                Console.WriteLine(aj[i]);
            }
            
            Console.ReadLine();

        }
            
            
            }
        }
    



