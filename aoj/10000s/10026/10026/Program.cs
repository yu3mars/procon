using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10026
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double num, ave, sigma, hh;
                num = double.Parse(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                else
                {
                    string[] str = Console.ReadLine().Split(' ');
                    ave = 0;
                    sigma = 0;
                    for (int i = 0; i < num; i++)
                    {
                        ave += double.Parse(str[i]);
                    }
                    ave = ave / num;
                    for (int i = 0; i < num; i++)
                    {
                        sigma += Math.Pow((double.Parse(str[i]) - ave),2);
                    }
                    hh = Math.Sqrt(sigma / num);
                    Console.WriteLine(hh);
                }
            }
        }
    }
}
