//author :rifad ahmed
// problem link : https://www.hackerrank.com/challenges/migratory-birds/problem
//my profile : https://www.hackerrank.com/rifad_ahmed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sock_Merchant
{
    class sockMerchant
    {
        static void Main(string[] args)
        {
            ReadLine();
            var n = ReadLine().Split(' ');
            var ar = Array.ConvertAll(n, int.Parse);




            int  i, j, countt = 0, add = 0;
            int[] aj = new int[ar.Length];

            

            for (i = 0; i < ar.Length; i++)
            {
                if (aj[i] == 0)
                {
                    countt = 0;
                    for (j = i; j < ar.Length; j++)
                    {
                        if (ar[i] == ar[j])
                        {
                            countt += 1;
                            aj[j] = 1;
                        }
                    }
                    add = add + (countt / 2);
                }
            }

            Console.WriteLine(add);

            ReadKey();





        }
    }
}
