//author :rifad ahmed
// problem link :
//my profile : https://www.hackerrank.com/rifad_ahmed

using System;
using System.Numerics;


namespace RectangleApplication
{
    class program
    {
        static void Main(string[] args)

        {


            var ar1 = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            var ar2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int i, j, min;
            string str = null;
            for(i=0;i<ar1[1];i++)
            {
                var ar3 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                min = ar2[ar3[0]];
                for(j=ar3[0];j<ar3[1];j++)
                {
                    if(ar2[j+1]<min)
                    {
                        min = ar2[j + 1];
                    }
                }
                str = str + min + "\n";
            }





            Console.WriteLine(str);
            Console.ReadLine();

        }
            
            
            }
        }
    



