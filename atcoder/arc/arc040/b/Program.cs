using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nr[0];
            int r = nr[1];
            string s = Console.ReadLine();
            bool[] b = new bool[n];
            int last = -11;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '.')
                {
                    b[i] = true;
                    last = i;
                }
            }
            if(last<0)
            {
                Console.WriteLine(0);
                return;
            }
            last = Math.Max(0, last - r + 1);
            int cnt = 0;
            for (int i = 0; i <= last; i++)
            {
                if (b[i] || i == last)
                {
                    cnt++;
                    for (int j = 0; j < r; j++)
                    {
                        if (i + j >= b.Length) break;
                        b[i + j] = false;
                    }
                }
                
            }
            Console.WriteLine(cnt + last);
        }
    }
}
