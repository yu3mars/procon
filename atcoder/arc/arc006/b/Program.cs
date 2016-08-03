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
            int[] nl = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
            int n = nl[0];
            int l = nl[1];
            string[] map = new string[l + 1];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = " " + Console.ReadLine() + " ";
            }
            int now = -1;
            for (int i = 0; i < map[map.Length - 1].Length; i++)
            {
                if (map[map.Length - 1][i] == 'o')
                {
                    now = i;
                    break;
                }
            }

            for (int i = map.Length - 2; i >= 0; i--)
            {
                if (map[i][now - 1] == '-')
                {
                    now-=2;
                }
                else if (map[i][now + 1] == '-')
                {
                    now+=2;
                }
            }
            Console.WriteLine((now + 1) / 2);
        }
    }
}
