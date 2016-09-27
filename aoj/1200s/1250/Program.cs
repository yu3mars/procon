using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1250
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long mod = ((long)1 << 32);
            for (int dataset = 0; dataset < n; dataset++)
            {
                List<string> lis = new List<string>();
                while(lis.Count<9)
                {
                    string[] strtmp = Console.ReadLine().Split(' ');
                    foreach (var strtm in strtmp)
                    {
                        lis.Add(strtm);
                    }
                }
                long[] ls = new long[9];
                for (int i = 0; i < 9; i++)
                {
                    ls[i] = Convert.ToInt64(lis[i], 16);
                }

                long ans = 0;
                for (int shift = 0; shift <= 32; shift++)
                {
                    long left = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        left += ls[i];
                    }
                    left %= mod;
                    left = (left >> shift) %2;
                    if (left != (ls[8] >> shift) % 2)
                    {
                        ans += ((long)1 << shift);
                        for (int i = 0; i < 9; i++)
                        {
                            ls[i] ^= (1 << shift);
                        }
                    }
                }


                Console.WriteLine(Convert.ToString(ans, 16));
            }
        }
    }
}
