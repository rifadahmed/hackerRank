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
            // ReadLine();
           
            var a =Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= a; i++)
            {

                for (int k = 0; k < (a - i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {


                    Console.Write("#");

                }
                Console.WriteLine("");






            }

            //Console.WriteLine(count);
            Console.ReadLine();
            }
        }
    }



