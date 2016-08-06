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
            int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = Math.Abs(ab[1] - ab[0]);
            int ans = 0;
            while (diff!=0)
            {
                if (diff >= 8) diff -= 10;
                else if (diff >= 3) diff -= 5;
                else diff--;

                diff = Math.Abs(diff);
                ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
