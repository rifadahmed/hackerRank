using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n, i, j;
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            int[] aj = new int[n];
            
            for (i = 0; i < n; i++)
            {
                 ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)

            {
                for (j = 0; j <= ar[i]; j++)
                {
                    if (j % 2 != 0)
                    {
                        m = m * 2;
                    }
                    else
                    {
                        m = m + 1;
                    }
                }
                aj[i] = m;
                m = 0;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(aj[i]);
            }
            Console.Read();
        }
    }
}
