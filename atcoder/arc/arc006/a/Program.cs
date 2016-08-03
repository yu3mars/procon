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
            int[] e = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
            int b = int.Parse(Console.ReadLine());
            int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;

            int cnt = 0;
            bool bonus = false;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (l[i] == e[j])
                    {
                        cnt++;
                        break;
                    }
                }
                if (l[i] == b)
                {
                    bonus = true;
                }
            }
            if (cnt == 6) Console.WriteLine(1);
            else if (cnt == 5 && bonus) Console.WriteLine(2);
            else if (cnt > 2) Console.WriteLine(8 - cnt);
            else Console.WriteLine(0);
        }
    }
}
