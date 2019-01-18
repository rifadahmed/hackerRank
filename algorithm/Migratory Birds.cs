using System;
using static System.Console;
using System.Collections.Generic;
namespace RectangleApplication
{

    class program
    {
        static void Main(string[] args)
        {


            ReadLine();

            var n = ReadLine().Split(' ');
            int maxx = 0, temp = 0, index = 0;

            
            var ar = Array.ConvertAll(n, int.Parse);
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > maxx)

                    maxx = ar[i];

            }
            int[] countt = new int[maxx + 1];
            for (int i = 0; i < ar.Length; i++)
            {

                countt[ar[i]]++;
            }



            for (int i = 0; i <= maxx; i++)
            {
                if (countt[i] > temp)
                {
                    temp = countt[i];
                    index = i;
                }
            }
            Console.WriteLine(index);

            Console.ReadLine();
        }


    }
}

