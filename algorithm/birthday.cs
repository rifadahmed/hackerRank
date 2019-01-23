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
            //int n = Convert.ToInt32(Console.ReadLine());
            ReadLine();
            var x = Console.ReadLine().Split(' ');
            var ar1 = Array.ConvertAll(x, int.Parse);//
            
            int maxx = 0,count1=0, count2 = 0, i, sum = 0;
			for(int i=0;i<ar1.Length-1;i++)
            {
                maxx = ar1[i];
				if(ar1[i+1]>maxx)
                {
                    maxx = ar1[i + 1];
                    count1++;
                }
            }


               
            Console.WriteLine(count1);
            Console.ReadLine();
        }
    }
}

