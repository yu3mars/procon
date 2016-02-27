using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] ls = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                ls[i] = int.Parse(str[i]);
            }
            ls[n] = ls[0];
            bool dec = false;
            int cnt = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (ls[i - 1] > ls[i])
                {
                    if (dec == true)
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                    else
                    {
                        dec = true;
                        cnt = i;
                    }
                }
            }
            if (cnt == 0)
            {
                cnt = n;
            }
            Console.WriteLine(n-cnt);
        }
    }
}
