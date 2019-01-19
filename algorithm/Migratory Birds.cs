//author :rifad ahmed
// problem link : https://www.hackerrank.com/challenges/migratory-birds/problem
//my profile : https://www.hackerrank.com/rifad_ahmed
using System;
using static System.Console;
using System.Collections.Generic;
namespace RectangleApplication
{

    class program
    {
        static void Main(string[] args)
        {


            //  ReadLine();
            Console.WriteLine("start");
            var n = ReadLine().Split('');
            //int maxx = 0, temp = 0, index = 0;

            
            var ar = Array.ConvertAll(n, char.Parse);

            for (int i=0;i<n.Length;i++)
            {
                Console.WriteLine(ar[i]);
            }
            

            Console.ReadLine();
        }


    }
}

