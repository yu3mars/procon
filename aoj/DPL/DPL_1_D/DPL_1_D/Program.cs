using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPL_1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lis = new int[n];
            int len = 1;
            lis[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int target = int.Parse(Console.ReadLine());
                if (lis[len-1] < target)
                {
                    lis[len] = target;
                    len += 1;
                }
                else
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (lis[j] > target)
                        {
                            lis[j] = target;
                            break;
                        }
                    }
                }                
            }
            Console.WriteLine(len);
        }
    }
}
