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
            int n = int.Parse(Console.ReadLine());
            bool[] ng = new bool[310];
            for (int i = 0; i < 3; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                if(tmp==n)
                {
                    Console.WriteLine("NO");
                    return;
                }
                ng[tmp] = true;
            }
            int now = n;
            int cnt = 0;
            while (n > 0)
            {
                cnt++;
                if (now <= 3)
                {
                    break;
                }
                if (ng[now - 3] == false)
                {
                    now -= 3;
                    continue;
                }
                if (ng[now - 2] == false)
                {
                    now -= 2;
                    continue;
                }
                if (ng[now - 1] == false)
                {
                    now -= 1;
                    continue;
                }
                Console.WriteLine("NO");
                return;
            }
            if(cnt>100)
            {
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine("YES");
            return;
        }
    }
}
