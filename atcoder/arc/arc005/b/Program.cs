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
            string[] xyw = Console.ReadLine().Split(' ');
            int x = int.Parse(xyw[0]) - 1;
            int y = int.Parse(xyw[1]) - 1;
            string w = xyw[2];

            int dy = 0;
            int dx = 0;
            for (int i = 0; i < w.Length; i++)
            {
                switch (w[i])
                {
                    case 'U':
                        dy = -1;
                        break;
                    case 'D':
                        dy = 1;
                        break;
                    case 'R':
                        dx = 1;
                        break;
                    case 'L':
                        dx = -1;
                        break;

                    default:
                        break;
                }
            }

            string[] map = new string[9];
            for (int i = 0; i < 9; i++)
            {
                map[i] = Console.ReadLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(map[y][x]);
                if (x + dx < 0 || x + dx > 8) dx = -dx;
                if (y + dy < 0 || y + dy > 8) dy = -dy;
                x += dx;
                y += dy;
            }
            Console.WriteLine();
        }
    }
}
