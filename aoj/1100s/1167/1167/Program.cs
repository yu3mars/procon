using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1167
{
    class Program
    {
        static int[] ls, odd;

        static void Main(string[] args)
        {
            ls = new int[1000010];
            odd = new int[1000010];
            for (int i = 1; i < ls.Length; i++)
            {
                ls[i] = int.MaxValue;
                odd[i] = int.MaxValue;
            }

            for (int i = 1; i < 181; i++)
            {
                int next = i * (i + 1) * (i + 2) / 6;
                Update(next);
            }

            for (; ; )
            {
                int tar = int.Parse(Console.ReadLine());
                if (tar == 0) return;
                Console.WriteLine("{0} {1}", ls[tar], odd[tar]);
            }
        }

        static void Update(int n)
        {
            for (int i = n; i < ls.Length; i++)
            {
                ls[i] = Math.Min(ls[i], ls[i - n] + 1);
            }

            if (n % 2 == 1)
            {
                for (int i = n; i < odd.Length; i++)
                {
                    odd[i] = Math.Min(odd[i], odd[i - n] + 1);
                }
            }
        }
    }
}
