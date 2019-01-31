//author :rifad ahmed
// problem link :
//my profile : https://www.hackerrank.com/rifad_ahmed

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
            ReadLine();
            var ar = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            Array.Sort(ar);
            int count = 0,i,j,min= ar[0],m=0,flag=10,p=0,q=0;
            string str = null;
            while(flag>0)
            {
                
                    
                    for (i = m; i < ar.Length; i++)
                    {
                         p = ar[i];
                         q = min;
                        ar[i] = ar[i] - min;
                        int x = ar[i];
                        
                            count++;
                        
                        
                    }
                
                if (p == 0)
                { flag = 0;

                    break;

                }
                else
                {
                    str = Convert.ToString(str + count + "\n");
                    count = 0;
                    for (j = 0; j < ar.Length; j++)
                    {
                        if (ar[j] > 0)
                        {
                            min = ar[j];
                            m = j;
                            break;
                        }
                    }
                }


                }




            Console.WriteLine(str);
            Console.ReadLine();

        }
            
            
            }
        }
    



