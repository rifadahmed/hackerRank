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
            var str = Console.ReadLine();

            int len = str.Length-1 ;
           // Console.WriteLine(len);
            for (int i = 0; i < len;)
            {

                if (i != len - 1)

                {
                    if (i > -1 && str[i] == str[i + 1])
                    {
                        str = str.Remove(i, 2);
                        len = str.Length;
                        //var c=str;
                        i--;
                    }
                    else

                        i++;
                }
                else
                    break;
                
            }
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Empty String");
            }
            else

                Console.WriteLine(str);



            Console.ReadLine();
        }
    }
}

