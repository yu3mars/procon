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
            string a = Console.ReadLine();
            if (a.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int ans = 0;
            int notkaibun = 0;
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                {
                    notkaibun++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length - 1 - i] && notkaibun == 1)
                {
                    ans += 24;
                }
                else if (a.Length / 2 == i && a.Length % 2 == 1 && notkaibun == 0)
                {
                    continue;
                }
                else
                {
                    ans += 25;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
