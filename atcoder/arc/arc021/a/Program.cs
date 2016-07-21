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
            int[][] map = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                map[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            bool ok = false;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (map[x][y] == map[x][y + 1]) ok = true;
                }
            }
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (map[x][y] == map[x + 1][y]) ok = true;
                }
            }
            if (ok) Console.WriteLine("CONTINUE");
            else Console.WriteLine("GAMEOVER");
        }
    }
}
