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

            int totalPage = Convert.ToInt32(Console.ReadLine());
            int pageNo = Convert.ToInt32(Console.ReadLine());
            int x, y;
            x = pageNo / 2;
            y = (totalPage-pageNo) / 2;
            if (pageNo == 1 || pageNo == totalPage || (pageNo == (totalPage - 1) && totalPage % 2 != 0))
            {
                Console.WriteLine(0);
            }
            else if ((pageNo == (totalPage - 1) && totalPage % 2 == 0))
            {
                Console.WriteLine(1);
            }
            else
            {
                if (x > y)
                {
                    Console.WriteLine(y);
                }
                else
                    Console.WriteLine(x);

            }

            //Console.WriteLine(count);
            Console.ReadLine();
            }
        }
    }



