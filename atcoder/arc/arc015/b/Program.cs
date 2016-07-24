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
            int n = int.Parse(Console.ReadLine());
            int[] ans = new int[6];
            for (int i = 0; i < n; i++)
            {
                double[] t = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double max = t[0];
                double min = t[1];

                if (max >= 35) ans[0]++;
                else if (max >= 30) ans[1]++;
                else if (max >= 25) ans[2]++;
                if (min >= 25) ans[3]++;
                if (min < 0 && max >= 0) ans[4]++;
                if (max < 0) ans[5]++;
            }
            Console.WriteLine(String.Join(" ", ans));
        }
    }
}
