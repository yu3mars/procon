using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] imos = new int[2410];
            for (int i = 0; i < n; i++)
            {
                int[] se = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
                se[0] -= se[0] % 5;
                se[1] = (se[1] + 4) / 5 * 5;
                if (se[1] % 100 == 60) se[1] = (se[1] / 100 + 1) * 100;
                imos[se[0]]++;
                imos[se[1]]--;
            }
            bool israin = false;
            int now = 0;

            for (int i = 0; i < imos.Length; i++)
            {
                now += imos[i];
                if(israin==false && now>0)
                {
                    israin = true;
                    Console.Write(i.ToString("D4"));
                    Console.Write("-");
                }
                else if(israin==true && now==0)
                {
                    israin = false;
                    Console.WriteLine(i.ToString("D4"));
                }
            }

        }
    }
}
