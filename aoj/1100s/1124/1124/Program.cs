using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1124
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string[] nq = Console.ReadLine().Split(' ');
                int n = int.Parse(nq[0]);
                int q = int.Parse(nq[1]);
                if (n == 0 && q == 0)
                {
                    return;
                }
                int[] date = new int[101];
                for (int i = 0; i < n; i++)
                {
                    string[] member = Console.ReadLine().Split(' ');
                    for (int j = 1; j < member.Length; j++)
                    {
                        date[int.Parse(member[j])] += 1;
                    }
                }
                int deru = q - 1;
                int ans = 0;
                for (int i = 0; i < date.Length; i++)
                {
                    if (deru < date[i])
                    {
                        deru = date[i];
                        ans = i;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
