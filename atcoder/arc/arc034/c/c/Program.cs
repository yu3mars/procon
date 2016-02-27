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
            Dictionary<int, int> dic = new Dictionary<int, int>();
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            for (int i = b + 1; i <= a; i++)
            {
                CheckPrime(i, dic);
            }

            int[] vals = new int[dic.Values.Count];
            dic.Values.CopyTo(vals, 0);

            long ans = 1;
            for (int i = 0; i < vals.Length;i++ )
            {
                ans = ans * (vals[i] + 1) % 1000000007;
            }
            Console.WriteLine(ans);
        }

        static void CheckPrime(int n, Dictionary<int, int> dic)
        {
            int left = n;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                while (left % i == 0)
                {
                    DicAdd(i, dic);
                    left /= i;
                }
            }
            if (left > 1)
            {
                DicAdd(left, dic);
            }
        }

        static void DicAdd(int n, Dictionary<int, int> dic)
        {
            if (dic.ContainsKey(n) == true)
            {
                dic[n] += 1;
            }
            else
            {
                dic.Add(n, 1);
            }
        }
    }
}
