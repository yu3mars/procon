using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) ans += i;
            }
            Console.WriteLine(ans);
        }
    }
}
