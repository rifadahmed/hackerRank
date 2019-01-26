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

            string reminder = null;
            string[] st = new string[n];

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(',');
                var ar = Array.ConvertAll(s, int.Parse);
                if (ar[1] <= 10)
                {
                    while (ar[0] >= ar[1])
                    {
                        reminder = reminder + (ar[0] % ar[1]);
                        ar[0] = ar[0] / ar[1];


                    }
                    st[i] = reminder + ar[0];
                    reminder = null;
                }
                else
                {
                   while(ar[0]>=ar[1])

                    {
                        int q= (ar[0] % ar[1]);
                        if(q>9)
                        {
                            
                            reminder = reminder + Convert.ToChar(q + 55);
                            ar[0] = ar[0] / ar[1];
                        }
                        else
                        {
                            reminder = reminder + (ar[0] % ar[1]);
                            ar[0] = ar[0] / ar[1];

                        }

                    }
                   if(ar[0]>9)
                    {
                        st[i] = reminder +Convert.ToChar(ar[0]+55);
                    }
                    else
                    {
                        st[i] = reminder + ar[0];
                    }
                    reminder = null;


                }




            }
            for (int i = 0; i < n; i++)
            {

                char[] charArray = st[i].ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);

            }

            Console.ReadLine();

        }
            
            
            }
}