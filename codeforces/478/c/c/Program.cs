using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                num[i] = int.Parse(str[i]);
            }
            for (int i = 2; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int tmp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = tmp;
                    }
                }
            }
            int ans = 0;
            int[] vx = new int[10] { 0, 0, 0, 0, 1, 1, 1, 2, 2, 3 };
            int[] vy = new int[10] { 0, 1, 2, 3, 0, 1, 2, 0, 1, 0 };
            int[] vz = new int[10] { 3, 2, 1, 0, 2, 1, 0, 1, 0, 0 };
            for (int i = 0; i < 10; i++)
            {
                if (num[0] - vx[i] >= 0 && num[1] - vy[i] >= 0 && num[2] - vz[i] >= 0)
                {
                    ans += 1;
                    num[0] -= vx[i];
                    num[1] -= vy[i];
                    num[2] -= vz[i];


                }
            }
            Console.WriteLine(ans);
        }
    }
}
