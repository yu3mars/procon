using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            if (m < n * 2 || n * 4 < m)
            {
                Console.WriteLine("-1 -1 -1");
                return;
            }
            int[] ans = new int[3];
            int nokori = m - n * 2;
            ans[2] = nokori / 2;
            ans[1] = nokori % 2;
            ans[0] = n - ans[1] - ans[2];
            Console.WriteLine(String.Join(" ", ans));
        }
    }
}
