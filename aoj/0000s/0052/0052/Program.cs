using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0052
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int target = int.Parse(Console.ReadLine());
                if (target == 0)
                {
                    return;
                }
                int ans = 0;
                while (target > 0)
                {
                    target = target / 5;
                    ans += target;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
