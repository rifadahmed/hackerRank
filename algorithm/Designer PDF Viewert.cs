//author :rifad ahmed
// problem link : https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
//my profile : https://www.hackerrank.com/rifad_ahmed
//date :19.1.19
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
            var n = ReadLine().Split(' ');
            var charr = Array.ConvertAll(n, char.Parse);
            int  i,value, maxx = 0;

            
            var str = ReadLine();
            int[] diff = new int[100];
            for ( i = 0; i < str.Length; i++)
            {
                value = str[i];
                diff[i] = value - 97;

            }
            for (i = 0; i < 26; i++)
            {
                if (diff[i] == i)
                {
                    diff[i] = i;
                }
            }
            for (i = 0; i < str.Length; i++)
            {

                if (charr[diff[i]] > maxx)
                {
                    maxx = charr[diff[i]];
                }
            }
            Console.WriteLine((maxx-48)*str.Length );

            //*(str.Length)

            Console.ReadLine();





        }
    }
}
